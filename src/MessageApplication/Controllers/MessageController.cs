using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MessageApplication.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageApplication.Controllers
{
    [Route("api/message")]
    public class MessageController : Controller
    {
        [Route("getmessage")]
        public IActionResult GetMessageData(int messagedUser) {
            MessagedUser messagedUserEnum = (MessagedUser)messagedUser;
            return Ok(ConstructDummyData().Where(x=>x.user==messagedUserEnum).Select(x=>x).ToList());
        }
        private List<MessageViewModel> ConstructDummyData()
        {
            List<MessageViewModel> messageData = new List<MessageViewModel>();
            messageData.Add(new MessageViewModel()
            {
                Id=1,
                Title="welcome",
                Message="very excited",
                user=MessagedUser.Agent
            });
            messageData.Add(new MessageViewModel()
            {
                Id = 2,
                Title = "welcom1",
                Message = "very cool",
                user = MessagedUser.Agent
            });
            messageData.Add(new MessageViewModel()
            {
                Id = 3,
                Title = "welcom3",
                Message = "very bad",
                user = MessagedUser.Agent
            });
            messageData.Add(new MessageViewModel()
            {
                Id = 4,
                Title = "welcome customer",
                Message = "very excited",
                user = MessagedUser.Customer
            });
            messageData.Add(new MessageViewModel()
            {
                Id = 5,
                Title = "welcome customer 1",
                Message = "very excited",
                user = MessagedUser.Customer
            });
            messageData.Add(new MessageViewModel()
            {
                Id = 6,
                Title = "welcome customer 2",
                Message = "very excited",
                user = MessagedUser.Agent
            });
            messageData.Add(new MessageViewModel()
            {
                Id = 7,
                Title = "welcome Canned",
                Message = "very excited canned",
                user = MessagedUser.Canned
            });
            messageData.Add(new MessageViewModel()
            {
                Id = 8,
                Title = "welcome Canned1",
                Message = "very excited",
                user = MessagedUser.Agent
            });
            messageData.Add(new MessageViewModel()
            {
                Id = 9,
                Title = "welcome Canned2",
                Message = "very excited",
                user = MessagedUser.Agent
            });
            return messageData;
        }
    }
}
