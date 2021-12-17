using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace hackaton.Models
{
    public class challengerStatus
    {
        public challengerStatus() 
        {
            challengers = new List<challenger>();
        }
        [Key]
        public int id_status { get; set; }
        public string name { get; set; }
        public IEnumerable<challenger> challengers { get; set; }
    }
}
