using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace hackaton.Models
{
    public class order
    {
        public order() 
        {
            challengers = new List<challenger>();
        }
        [Key]
        public Guid id_order { get; set; }
        [Required(ErrorMessage = "Имя должно быть заполнено")]
        public string name { get; set; }
        [Required(ErrorMessage = "Описание должно быть заполнено")]
        public string description { get; set; }
        [Required(ErrorMessage = "Должно быть заполнено")]
        public float cost { get; set; }
        public Guid user_id { get; set; }
        public int id_status { get; set; }
        public int due_date { get; set; }
        public int due_date_term { get; set; }
        public Guid id_category { get; set; }
        public IEnumerable<challenger> challengers { get; set; }
        public category category { get; set; }
        public orderStatus orderStatus { get; set; }
        public user user { get; set; }
    }
}
