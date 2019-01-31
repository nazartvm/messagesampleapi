using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageApplication.Models
{
    public class MessageViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public MessagedUser user { get; set; }
    }
    public enum MessagedUser
    {
        Customer,
        Agent,
        Canned
    }
}
