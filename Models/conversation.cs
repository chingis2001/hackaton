using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace hackaton.Models
{
    public class conversation
    {
        public conversation() 
        {
            participants = new List<participant>();
        }
        [Key]
        public Guid id_conv { get; set; }
        public DateTime date_creation { get; set; }
        public string name { get; set; }
        public IEnumerable<participant> participants { get; set; }
    }
}
