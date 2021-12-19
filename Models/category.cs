using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace hackaton.Models
{
    public class category
    {
        public category()
        {
            orders = new List<order>();
            categories = new List<category>();
        }
        [Key]
        public Guid id_category { get; set; }
        public Guid? id_upper { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public string description { get; set; }
        public IEnumerable<order> orders { get; set; }
        public IEnumerable<category> categories { get; set; }
        public category upper { get; set; }
    }
}
