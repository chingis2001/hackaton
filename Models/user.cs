using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace hackaton.Models
{
    public class user
    {
        public user() 
        {
            challenges = new List<challenger>();
            participations = new List<participant>();
            orders = new List<order>();
        }
        [Key]
        public Guid user_id { get; set; }
        [Required(ErrorMessage = "заполните имя")]
        public string firstname { get; set; }
        [Required(ErrorMessage = "заполните фамилию")]
        public string secondname { get; set; }
        [Required(ErrorMessage = "пароль должен быть заполнен")]
        public string password { get; set; }
        public string _salt { get; set; }
        public string _token { get; set; }
        public double balance { get; set; }
        public int status_id { get; set; }
        [Required(ErrorMessage = "не должно быть пустым")]
        public string username { get; set; }
        [Required(ErrorMessage = "не должно быть пустым")]
        public string email { get; set; }
        public IEnumerable<challenger> challenges { get; set; }
        public IEnumerable<participant> participations { get; set; }
        public IEnumerable<order> orders { get; set; }
        public userStatus userStatus { get; set; }
    }
}
