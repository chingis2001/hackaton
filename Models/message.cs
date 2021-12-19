using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace hackaton.Models
{
    public class message
    {
        [Key]
        public Guid id_message { get; set; }
        [Required(ErrorMessage = "Сообщение должно быть заполнено")]
        public string text { get; set; }
        public DateTime date_sent { get; set; }
        public Guid id_conv { get; set; }
        public Guid user_id { get; set; }
        public participant participant { get; set; }
    }
}
