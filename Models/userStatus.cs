using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace hackaton.Models
{
    public class userStatus
    {
        public userStatus() 
        {
            users = new List<user>();
        }
        [Key]
        public int status_id { get; set; }
        public string name { get; set; }
        public IEnumerable<user> users { get; set; }
    }
}
