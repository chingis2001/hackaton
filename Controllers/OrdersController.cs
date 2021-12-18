using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using hackaton.Models;
using System.Threading.Tasks;

namespace hackaton.Controllers
{
    public class OrdersController : Controller
    {
        private readonly hackatonContext _context;
        public OrdersController(hackatonContext context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCategories(string? name_cat) 
        {
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
            List<category> tmp_cats = new List<category>();
            foreach (var cat in categories) 
                tmp_cats.AddRange(_context.category.Where(t => t.id_upper == cat.id_category).ToList());
            categories.AddRange(tmp_cats);
            categories.Add(upper);
            return View(categories);
        }
        public IActionResult GetOrders(string? name_cat) 
        {
            var level_ones = _context.category.Where(t => t.level == 1).Select(t => t.name).ToList();
            ViewBag.upper = level_ones;
            var category = _context.category.FirstOrDefault(t => t.name == name_cat);
            int level_cat = category.level;
            if (level_cat == 1) 
            {
                return RedirectToAction("GetCategories", new { name_cat = name_cat });
            }
            var orders = _context.order.Where(t => t.id_category == category.id_category).ToList();
            return View(orders);
        }
        public IActionResult FilterOrders(string name_cat, string start_cost, string end_cost, string due_term) 
        {
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
            Guid id_ord = Guid.Parse(id);
            var order = _context.order.FirstOrDefault(t => t.id_order == id_ord);
            return View(id_ord);
        }
        [HttpGet]
        public IActionResult CreateOrder() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateOrder(order order) 
        {
            Guid userId = Guid.Parse(User.Identity.Name);
            order.id_status = 1;
            order.user_id = userId;
            return RedirectToAction("GetOrders", new { name_cat = order.id_category });
        }
    }
}
