using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using hackaton.Models;

namespace hackaton.hubs
{
    public class ChatHub : Hub
    {
        private hackatonContext _context;
        public ChatHub(hackatonContext context) 
        {
            _context = context;
        }
        public async Task SendMessage(string? id = "", string? text = "", string? friendid = "") 
        {
            var UserName = Context.User.Identity.Name;
            if (id == "")
            {

                conversation беседа = new conversation
                {
                    id_conv = Guid.NewGuid(),
                    date_creation = DateTime.Now,
                    name = "personal"
                };
                participant participant = new participant
                {
                    id_conv = беседа.id_conv,
                    date_add = DateTime.Now,
                    last_seen = DateTime.Now,
                    user_id = Guid.Parse(UserName),
                };
                participant participant2 = new participant
                {
                    id_conv = беседа.id_conv,
                    date_add = DateTime.Now,
                    last_seen = DateTime.Now,
                    user_id = Guid.Parse(friendid),
                };
                _context.Add(беседа);
                _context.Add(participant);
                _context.Add(participant2);
                List<participant> participants = new List<participant>();
                participants.Add(participant);
                participants.Add(participant2);
                message сообщениеновое = new message
                {
                    id_conv = беседа.id_conv,
                    user_id = Guid.Parse(UserName.ToLower()),
                    date_sent = DateTime.Now,
                    text = text
                };
                _context.Add(сообщениеновое);
                user userновый = _context.user.FirstOrDefault(t => t.user_id == Guid.Parse(UserName));
                _context.SaveChanges();
                foreach (var item in participants)
                {
                    var covertantId = participants.FirstOrDefault(t => t.user_id != item.user_id).user_id;
                    var covertant = _context.user.FirstOrDefault(t => t.user_id == covertantId);
                    try
                    {
                        await Clients.User(item.user_id.ToString().ToLower()).SendAsync("MessageSend", new
                        {
                            user_send = сообщениеновое.user_id,
                            id_conv = сообщениеновое.id_conv,
                            conv_name = covertant.secondname + " " + covertant.firstname,
                            conv_user_id = covertant.user_id,
                            date = сообщениеновое.date_sent.Hour + " " + сообщениеновое.date_sent.Minute,
                            text = сообщениеновое.text,
                            firstname = userновый.firstname,
                            secondname = userновый.secondname
                        });
                    }
                    catch (Exception ex)
                    {
                        var a = 1;
                    }
                }
            }
            else
            {
                message сообщение = new message
                {
                    id_conv = Guid.Parse(id),
                    user_id = Guid.Parse(UserName.ToLower()),
                    date_sent = DateTime.Now,
                    text = text
                };
                _context.Add(сообщение);
                user user = _context.user.FirstOrDefault(t => t.user_id == Guid.Parse(UserName));
                var members = _context.participant.Where(t => t.id_conv == Guid.Parse(id)).ToList();
                conversation беседа = _context.conversation.Include(t => t.participants).FirstOrDefault(t => t.id_conv == Guid.Parse(id));
                string conv_name = "";
                _context.SaveChanges();
                if (беседа.participants.Count() == 2)
                {
                    var covertantId = members.FirstOrDefault(t => t.user_id != Guid.Parse(UserName)).user_id;
                    var covertant = _context.user.FirstOrDefault(t => t.user_id == covertantId);
                    await Clients.All.SendAsync("MessageSend", new
                    {
                        flag = 1,
                        user_send = сообщение.user_id,
                        id_conv = сообщение.id_conv,
                        conv_name = covertant.secondname + " " + covertant.firstname,
                        conv_user_id = covertant.user_id,
                        date = сообщение.date_sent.ToLongDateString(),
                        time = сообщение.date_sent.Hour + ":" + сообщение.date_sent.Minute,
                        text = сообщение.text,
                        firstname = user.firstname,
                        secondname = user.secondname
                    });
                    /*foreach (var item in members)
                    {
                        var covertantId = members.FirstOrDefault(t => t.user_id != item.user_id).user_id;
                        var covertant = _context.user.FirstOrDefault(t => t.user_id == covertantId);
                        await Clients.All.SendAsync("MessageSend", new
                        {
                            flag = 1,
                            user_send = сообщение.user_id,
                            id_conv = сообщение.id_conv,
                            conv_name = covertant.secondname + " " + covertant.firstname,
                            conv_user_id = covertant.user_id,
                            date = сообщение.date_sent.ToLongDateString(),
                            time = сообщение.date_sent.Hour + ":" + сообщение.date_sent.Minute,
                            text = сообщение.text,
                            firstname = user.firstname,
                            secondname = user.secondname
                        });
                        if (item.user_id.ToString().ToLower() == UserName.ToLower())
                        {
                            //Clients.User(item.user_id.ToString().ToLower())
                            await Clients.User(item.user_id.ToString().ToLower()).SendAsync("MessageSend", new
                            {
                                flag = 1,
                                user_send = сообщение.user_id,
                                id_conv = сообщение.id_conv,
                                conv_name = covertant.secondname + " " + covertant.firstname,
                                conv_user_id = covertant.user_id,
                                date = сообщение.date_sent.ToLongDateString(),
                                time = сообщение.date_sent.Hour + ":" + сообщение.date_sent.Minute,
                                text = сообщение.text,
                                firstname = user.firstname,
                                secondname = user.secondname
                            });
                        }
                        else
                        {
                            await Clients.User(item.user_id.ToString().ToLower()).SendAsync("MessageSend", new
                            {
                                user_send = сообщение.user_id,
                                id_conv = сообщение.id_conv,
                                conv_name = covertant.secondname + " " + covertant.firstname,
                                conv_user_id = covertant.user_id,
                                date = сообщение.date_sent.ToLongDateString(),
                                time = сообщение.date_sent.Hour + ":" + сообщение.date_sent.Minute,
                                text = сообщение.text,
                                firstname = user.firstname,
                                secondname = user.secondname
                            });
                        }
                    }
                    */    
            }
                else
                {
                    conv_name = беседа.name;
                    foreach (var item in members)
                    {
                        var covertantId = members.FirstOrDefault(t => t.user_id != item.user_id).user_id;
                        var covertant = _context.user.FirstOrDefault(t => t.user_id == covertantId);
                        await Clients.User(item.user_id.ToString().ToLower()).SendAsync("MessageSend", new
                        {
                            user_send = сообщение.user_id,
                            id_conv = сообщение.id_conv,
                            conv_name = covertant.secondname + " " + covertant.firstname,
                            conv_user_id = covertant.user_id,
                            date = сообщение.date_sent.ToLongDateString(),
                            time = сообщение.date_sent.Hour + ":" + сообщение.date_sent.Minute,
                            text = сообщение.text,
                            firstname = user.firstname,
                            secondname = user.secondname
                        });
                    }
                }
            }
        }
    }
}
