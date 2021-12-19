using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace hackaton.Models
{
    public class orderStatus
    {
        public orderStatus() 
        {
            orders = new List<order>();
        }
        [Key]
        public int id_status { get; set; }
        public string name { get; set; }
        public IEnumerable<order> orders { get; set; }
    }
}
