using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using hackaton.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace hackaton.Controllers
{
    public class OrdersController : Controller
    {
        private static readonly string login_tel = "Mong1223";
        private static readonly string psw_tel = "Mongush1223";
        private readonly hackatonContext _context;
        public OrdersController(hackatonContext context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (User.Identity.Name != null)
            {
                Guid iid = Guid.Parse(User.Identity.Name);
                user usr = _context.user.FirstOrDefault(t => t.user_id == iid);
                ViewBag.Balance = usr.balance;

            }
            return View();
        }
        public IActionResult GetCategories(string? name_cat) 
        {
            //Костыли мои костыли
            if (User.Identity.Name != null)
            {
                Guid iid = Guid.Parse(User.Identity.Name);
                user usr = _context.user.FirstOrDefault(t => t.user_id == iid);
                ViewBag.Balance = usr.balance;

            }
            var category = _context.category.FirstOrDefault(t => t.name == name_cat);
            var level_ones = _context.category.Where(t => t.level == 1).Select(t => t.name).ToList();
            ViewBag.upper = level_ones;
            int level_cat = category.level;
            category upper = category;
            if (level_cat == 2) 
                upper = _context.category.FirstOrDefault(t => t.id_category == category.id_upper);
            if (level_cat == 3) {
                var upper_tmp = _context.category.FirstOrDefault(t => t.id_category == category.id_upper);
                upper = _context.category.FirstOrDefault(t => t.id_category == upper_tmp.id_upper);
            }
            List<category> categories = _context.category.Where(t => t.id_upper == upper.id_category).ToList();
            List<category> res_cats = new List<category>();
            res_cats.Add(upper);
            foreach (var cat in categories)
            {
                res_cats.Add(cat);
                res_cats.AddRange(_context.category.Where(t => t.id_upper == cat.id_category).ToList());
            }
            return View(res_cats);
        }
        public IActionResult GetOrders(string? name_cat) 
        {
            if (User.Identity.Name != null)
            {
                Guid iid = Guid.Parse(User.Identity.Name);
                user usr = _context.user.FirstOrDefault(t => t.user_id == iid);
                ViewBag.Balance = usr.balance;

            }
            var level_ones = _context.category.Where(t => t.level == 1).Select(t => t.name).ToList();
            ViewBag.upper = level_ones;
            var category = _context.category.FirstOrDefault(t => t.name == name_cat);
            int level_cat = category.level;
            if (level_cat == 1) 
            {
                return RedirectToAction("GetCategories", new { name_cat = name_cat });
            }
            ViewBag.Category = category.name;
            ViewBag.Category_Desc = category.description;
            var orders = _context.order.Include(t => t.orderStatus).Where(t => t.id_category == category.id_category && t.id_status != 4).ToList();
            return View(orders);
        }
        public IActionResult FilterOrders(string name_cat, string start_cost, string end_cost, string due_term) 
        {
            if (User.Identity.Name != null)
            {
                Guid iid = Guid.Parse(User.Identity.Name);
                user usr = _context.user.FirstOrDefault(t => t.user_id == iid);
                ViewBag.Balance = usr.balance;

            }
            var category = _context.category.FirstOrDefault(t => t.name == name_cat);
            IQueryable<order> ords = _context.order.Where(t => t.id_category == category.id_category);
            float f_end_cost = 99999;
            float f_start_cost = 0;
            int i_due_term = 1000;
            if(end_cost != "") 
            {
                f_end_cost = (float)Convert.ToDouble(end_cost);
                ords = ords.Where(t => t.cost < f_end_cost);
            }
            if (start_cost != "") 
            {
                f_start_cost = (float)Convert.ToDouble(start_cost);
                ords = ords.Where(t => t.cost > f_start_cost);
            }
            if (due_term != "") 
            {
                i_due_term = Convert.ToInt16(due_term);
                ords = ords.Where(t => t.due_date < i_due_term);
            }
            var ret_ords = ords.ToList();
            return PartialView("_Orders", ret_ords);
        }
        public IActionResult GetOrderInfo(string id) 
        {
            /*
             * Костыль ёпта: 0 - ничего не может, 1 - создатель, 2 - принял участие, 
             * 3 - выполняет, 4 - подписаться, 5 - создатель, ещё и посмотреть кандидатов,
             * 6 - создатель, может заплатить за работу
             * 7 - создатель, может завершить работу
             */
            if (User.Identity.Name != null)
            {
                Guid iid = Guid.Parse(User.Identity.Name);
                user usr = _context.user.FirstOrDefault(t => t.user_id == iid);
                ViewBag.Balance = usr.balance;

            }
            var level_ones = _context.category.Where(t => t.level == 1).Select(t => t.name).ToList();
            ViewBag.upper = level_ones;
            Guid id_ord = Guid.Parse(id);
            var order = _context.order.Include(t=>t.user).Include(t=>t.challengers)
                .Include(t=>t.orderStatus).Include(t=>t.category).FirstOrDefault(t => t.id_order == id_ord);
            int action = 0;
            if (order.user_id == Guid.Parse(User.Identity.Name) && order.id_status == 1)
                action = 1; 
            var chall = _context.challenger.Include(t => t.challengerStatus)
                .FirstOrDefault(t => t.user_id == Guid.Parse(User.Identity.Name) && t.id_order == id_ord);
            if (chall != null)
            {
                if (chall.id_status == 1)
                    action = 2;
                else if (chall.id_status == 2)
                    action = 3;
            }
            else if (User.IsInRole("Подтверждённый исполнитель") && chall == null)
            {
                action = 4;
            }
            else if (order.user_id == Guid.Parse(User.Identity.Name) && order.id_status == 1)
            {
                action = 5;
            }
            else if (order.user_id == Guid.Parse(User.Identity.Name) && order.id_status == 2)
            {
                action = 6;
            }
            else if (order.user_id == Guid.Parse(User.Identity.Name) && order.id_status == 3) 
            {
                action = 7;
            }
            ViewBag.action = action;
            return View(order);
        }
        public IActionResult PayForOrder(string id) 
        {
            if (User.Identity.Name != null)
            {
                Guid iid = Guid.Parse(User.Identity.Name);
                user iusr = _context.user.FirstOrDefault(t => t.user_id == iid);
                ViewBag.Balance = iusr.balance;

            }
            Guid IdUser = Guid.Parse(User.Identity.Name);
            Guid order_id = Guid.Parse(id);
            order ord = _context.order.FirstOrDefault(t => t.id_order == order_id);
            ord.id_status = 3;
            user usr = _context.user.FirstOrDefault(t => t.user_id == IdUser);
            if (usr.balance - ord.cost < 0) 
            {
                return Json(new
                {
                    payed = "false"
                });
            }
            usr.balance -= ord.cost;
            _context.Update(ord);
            _context.Update(usr);
            _context.SaveChanges();
            return Json(new
            {
                payed = "true"
            });
        }
        public IActionResult CloseOrder(string id) 
        {
            if (User.Identity.Name != null)
            {
                Guid iid = Guid.Parse(User.Identity.Name);
                user iusr = _context.user.FirstOrDefault(t => t.user_id == iid);
                ViewBag.Balance = iusr.balance;

            }
            Guid IdUser = Guid.Parse(User.Identity.Name);
            Guid order_id = Guid.Parse(id);
            order ord = _context.order.FirstOrDefault(t => t.id_order == order_id);
            ord.id_status = 4;
            user usr = _context.user.FirstOrDefault(t => t.user_id == IdUser);
            challenger chall = _context.challenger.Include(t=>t.order).FirstOrDefault(t => t.id_order == order_id && t.id_status == 4);
            user chall_usr = _context.user.FirstOrDefault(t => t.user_id == chall.user_id);
            chall_usr.balance += chall.order.cost;
            _context.Update(chall_usr);
            _context.Update(ord);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult CreateOrder() 
        {
            if (User.Identity.Name != null)
            {
                Guid iid = Guid.Parse(User.Identity.Name);
                user usr = _context.user.FirstOrDefault(t => t.user_id == iid);
                ViewBag.Balance = usr.balance;

            }
            var level1 = _context.category.Where(t => t.level == 1).Select(t=>t.name).ToList();
            ViewBag.upper = level1;
            var types = _context.category.Where(t => t.level == 3).Select(t => t.name).ToList();
            ViewBag.types = types;
            return View();
        }
        [HttpPost]
        public IActionResult CreateOrder(order order,string? category) 
        {
            if (User.Identity.Name != null)
            {
                Guid iid = Guid.Parse(User.Identity.Name);
                user usr = _context.user.FirstOrDefault(t => t.user_id == iid);
                ViewBag.Balance = usr.balance;

            }
            Guid userId = Guid.Parse(User.Identity.Name);
            order.id_order = Guid.NewGuid();
            var cat = _context.category.FirstOrDefault(t => t.name == category);
            order.id_category = cat.id_category;
            order.id_status = 1;
            order.user_id = userId;
            order.due_date_term = "days";
            _context.order.Add(order);
            _context.SaveChanges();
            return RedirectToAction("GetUserOrders", new { name_cat = order.id_category });
        }
        public IActionResult GetUserOrders() 
        {
            if (User.Identity.Name != null)
            {
                Guid iid = Guid.Parse(User.Identity.Name);
                user usr = _context.user.FirstOrDefault(t => t.user_id == iid);
                ViewBag.Balance = usr.balance;

            }
            var level_ones = _context.category.Where(t => t.level == 1).Select(t => t.name).ToList();
            List<order> ords = new List<order>();
            ViewBag.upper = level_ones;
            if (User.IsInRole("Заказчик"))
            {
                Guid UserId = Guid.Parse(User.Identity.Name);
                ords = _context.order.Include(t => t.orderStatus).Where(t => t.user_id == UserId && t.id_status != 4).ToList();
            }
            else if (User.IsInRole("Подтверждённый исполнитель")) 
            {
                Guid UserId = Guid.Parse(User.Identity.Name);
                ords = (from challangers in _context.challenger
                        join orders in _context.order
                        on challangers.id_order equals orders.id_order
                        where challangers.user_id == UserId && orders.id_status != 4
                        select orders).Include(t => t.orderStatus).ToList();
            }
            return View(ords);
        }
        public IActionResult GetChallangers(string id) 
        {
            if (User.Identity.Name != null)
            {
                Guid iid = Guid.Parse(User.Identity.Name);
                user usr = _context.user.FirstOrDefault(t => t.user_id == iid);
                ViewBag.Balance = usr.balance;

            }
            Guid id_order = Guid.Parse(id);
            var users = (from challangers in _context.challenger
                         join users_db in _context.user
                         on challangers.user_id equals users_db.user_id
                         where challangers.id_order == id_order && challangers.id_status == 1
                         select users_db).ToList();
            var level_ones = _context.category.Where(t => t.level == 1).Select(t => t.name).ToList();
            ViewBag.upper = level_ones;
            ViewBag.id_order = id_order;
            return View(users);
        }
        public IActionResult GetAcceptions() 
        {
            if (User.Identity.Name != null)
            {
                Guid iid = Guid.Parse(User.Identity.Name);
                user usr = _context.user.FirstOrDefault(t => t.user_id == iid);
                ViewBag.Balance = usr.balance;

            }
            Guid id_user = Guid.Parse(User.Identity.Name);
            var challs = _context.challenger.Include(t=>t.order).Where(t => t.user_id == id_user && t.order.id_status != 4).ToList();
            var level_ones = _context.category.Where(t => t.level == 1).Select(t => t.name).ToList();
            ViewBag.upper = level_ones;
            return View(challs);
        }
        public IActionResult GetVerifyTel(string tel) 
        {
            Random rnd = new Random();
            string verify_num = "";
            verify_num += rnd.Next(10).ToString();
            verify_num += rnd.Next(10).ToString();
            verify_num += rnd.Next(10).ToString();
            verify_num += rnd.Next(10).ToString();
            string url = "https://smsc.ru/sys/send.php?login=Mong1223&psw=Mongush1223";
            url += "&phones=<+7" + tel + ">";
            url += "&mes=Ваш код:" + verify_num.ToString();
            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            HttpContext.Session.SetString("verify_num", verify_num.ToString());
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream()) 
            {
                using (StreamReader reader = new StreamReader(stream)) 
                {
                    string line = reader.ReadLine();
                }
            }
            response.Close();
            return Json(new
            {
                status = "200Ok"
            });
        }
        public IActionResult VerifyTel(string verify) 
        {
            int right_num = Convert.ToInt32(HttpContext.Session.GetString("verify_num"));
            int user_num = Convert.ToInt32(verify);
            if (right_num != user_num) 
            {
                return Json(new
                {
                    status = "401BadRequest"
                });
            }
            return Json(new
            {
                status = "200Ok"
            });
        }
        public IActionResult AcceptToOrder(string id, string? code) 
        {
            Guid id_order = Guid.Parse(id);
            Guid id_user = Guid.Parse(User.Identity.Name);
            challenger chall = _context.challenger.FirstOrDefault(t => t.id_order == id_order && t.user_id == id_user);
            order order = _context.order.FirstOrDefault(t => t.id_order == chall.id_order);
            if (chall.id_status == 4) 
            {
                chall.id_status = 2;
                order.day_started = null;
                order.id_status = 1; 
                _context.Update(order);
                _context.Update(chall);
                _context.SaveChanges();
                return Json(new
                {
                    accepted = "false"
                });
            }
            int right_num = Convert.ToInt32(HttpContext.Session.GetString("verify_num"));
            int user_num = Convert.ToInt32(code);
            if (right_num != user_num)
            {
                return Json(new
                {
                    accepted = "false"
                });
            }
            chall.id_status = 4;
            order.day_started = DateTime.Now;
            order.id_status = 2;
            _context.Update(order);
            _context.Update(chall);
            _context.SaveChanges();
            return Json(new
            {
                accepted = "true"
            });
        }
        public IActionResult AcceptSubscript(string id_user, string id_order) 
        {
            challenger challenger = _context.challenger
                .FirstOrDefault(t => t.user_id == Guid.Parse(id_user) && t.id_order == Guid.Parse(id_order));
            string ack = "true";
            if (challenger.id_status == 1)
                challenger.id_status = 2;
            else
            {
                challenger.id_status = 1;
                ack = "false";
            }
            _context.Update(challenger);
            _context.SaveChanges();
            return Json(new 
            {
                accepted = ack
            });
        }
        public IActionResult SubscribeToOrder(string id) 
        {
            Guid id_user = Guid.Parse(User.Identity.Name);
            challenger found_chall = _context.challenger.FirstOrDefault(t => t.user_id == id_user && t.id_order == Guid.Parse(id));
            if (found_chall != null) 
            {
                _context.challenger.Remove(found_chall);
                _context.SaveChanges();
                return Json(new
                {
                    subscribed = "false"
                });
            }
            challenger challenger = new challenger();
            challenger.user_id = id_user;
            challenger.id_order = Guid.Parse(id);
            challenger.id_status = 1;
            _context.challenger.Add(challenger);
            _context.SaveChanges();
            return Json(new
            {
                subscribed = "true"
            });
        }
    }
}
