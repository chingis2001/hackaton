using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hackaton.Models
{
    public class ConversationsWithLastMessage
    {
        public ConversationsWithLastMessage() 
        {
            Пользователь = new List<user>();
        }
        public IEnumerable<user> Пользователь { get; set; }
        public conversation беседа { get; set; }
        public message сообщение { get;set; }
    }
}
