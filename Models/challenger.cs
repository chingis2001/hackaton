using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace hackaton.Models
{
    public class challenger
    {
        public Guid user_id { get; set; }
        public Guid id_order { get; set; }
        public int id_status { get; set; }
        public user user { get; set; }
        public order order { get; set; }
        public challengerStatus challengerStatus { get; set; }
    }
}
