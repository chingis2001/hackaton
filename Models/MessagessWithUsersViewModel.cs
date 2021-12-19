using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hackaton.Models
{
    public class MessagessWithUsersViewModel
    {
        public MessagessWithUsersViewModel() 
        {
            сообщения = new List<message>();
            пользователи = new List<user>();
        }
        public IEnumerable<message> сообщения { get; set; }
        public IEnumerable<user> пользователи { get; set; }
    }
}
