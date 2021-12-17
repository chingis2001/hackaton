using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hackaton.Models
{
    public class participant
    {
        public participant() 
        {
            messages = new List<message>();
        }
        public Guid id_conv { get; set; }
        public Guid user_id { get; set; }
        public DateTime last_seen { get; set; }
        public DateTime date_add { get; set; }
        public IEnumerable<message> messages { get; set; }
        public conversation conversation { get; set; }
        public user user { get; set; }
    }
}
