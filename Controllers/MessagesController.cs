using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using hackaton.Models;
using Microsoft.AspNetCore.Authorization;

namespace hackaton.Controllers
{
    public class MessagesController : Controller
    {
        private readonly hackatonContext _context;
        public MessagesController(hackatonContext context) 
        {
            _context = context;
        }
        public IActionResult Conversations()
        {
            if (User.Identity.Name != null)
            {
                Guid iid = Guid.Parse(User.Identity.Name);
                user usr = _context.user.FirstOrDefault(t => t.user_id == iid);
                ViewBag.Balance = usr.balance;

            }
            var level_ones = _context.category.Where(t => t.level == 1).Select(t => t.name).ToList();
            ViewBag.upper = level_ones;
            Guid IdUser = Guid.Parse(HttpContext.User.Identity.Name);
            IEnumerable<participant> участия = _context.participant.Where(t => t.user_id == IdUser).ToList();
            List<ConversationsWithLastMessage> беседы = new List<ConversationsWithLastMessage>();
            foreach (var item in участия)
            {
                List<user> пользователи = new List<user>();
                var беседа = _context.conversation.Include(t => t.participants).FirstOrDefault(t => t.id_conv == item.id_conv);
                foreach (var участник in беседа.participants)
                {
                    пользователи.Add(_context.user.FirstOrDefault(t => t.user_id == участник.user_id));
                }
                var сообщение = _context.message.Where(t => t.id_conv == беседа.id_conv).OrderBy(t => t.date_sent).Last();
                беседы.Add(new ConversationsWithLastMessage
                {
                    беседа = беседа,
                    Пользователь = пользователи,
                    сообщение = сообщение
                });
            }
            беседы = беседы.OrderByDescending(t => t.сообщение.date_sent).ToList();
            return View(беседы);
        }
        public IActionResult Dialog(string id, string? typeid)
        {
            if (User.Identity.Name != null)
            {
                Guid iid = Guid.Parse(User.Identity.Name);
                user usr = _context.user.FirstOrDefault(t => t.user_id == iid);
                ViewBag.Balance = usr.balance;

            }
            var level_ones = _context.category.Where(t => t.level == 1).Select(t => t.name).ToList();
            ViewBag.upper = level_ones;
            Guid IdUser = Guid.Parse(HttpContext.User.Identity.Name);
            List<user> Пользователи = new List<user>();
            List<message> Сообщения;
            MessagessWithUsersViewModel messagessWithUsersViewModel;
            if (id == null)
            {
                RedirectToAction("Conversations");
            }
            if (typeid != null)
            {
                if (typeid == "friendid")
                {
                    Guid IdFriend = Guid.Parse(id);
                    Microsoft.Data.SqlClient.SqlParameter param1 = new Microsoft.Data.SqlClient.SqlParameter("@ID1", IdFriend);
                    Microsoft.Data.SqlClient.SqlParameter param2 = new Microsoft.Data.SqlClient.SqlParameter("@ID2", IdUser);
                    conversation беседа_персональная = _context.conversation.FromSqlRaw("EXECUTE GetPersonalConvs @ID1, @ID2", new SqlParameter[] { param1, param2 }).AsEnumerable().FirstOrDefault();
                    if (беседа_персональная == null)
                    {
                        Пользователи.Add(_context.user.FirstOrDefault(t => t.user_id == IdUser));
                        Пользователи.Add(_context.user.FirstOrDefault(t => t.user_id == IdFriend));
                        Сообщения = new List<message>();
                        messagessWithUsersViewModel = new MessagessWithUsersViewModel
                        {
                            сообщения = Сообщения,
                            пользователи = Пользователи
                        };
                        return View(messagessWithUsersViewModel);
                    }
                    id = беседа_персональная.id_conv.ToString();
                }
            }
            Guid Id = Guid.Parse(id);
            conversation беседа = _context.conversation.Include(t => t.participants).FirstOrDefault(t => t.id_conv == Id);
            Сообщения = _context.message.Include(t => t.participant).Where(t => t.id_conv == Id).OrderBy(t => t.date_sent).Take(100).ToList();
            bool isForCurrentUser = false;
            /*if (беседа == null) 
            {
                var Id_бесед = _context.Участник.Where(t => t.ID_Пользователя == Id).Select(t => t.ID_беседы).ToList();
                List<Беседа> беседы_личные = new List<Беседа>();
                foreach (var idшка in Id_бесед) 
                {
                    беседы_личные
                }
            }*/
            foreach (var item in беседа.participants)
            {
                Пользователи.Add(_context.user.FirstOrDefault(t => t.user_id == item.user_id));
                if (item.user_id == IdUser)
                    isForCurrentUser = true;
            }
            messagessWithUsersViewModel = new MessagessWithUsersViewModel
            {
                сообщения = Сообщения,
                пользователи = Пользователи
            };
            if (isForCurrentUser)
                return View(messagessWithUsersViewModel);
            return RedirectToAction("Conversations");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
