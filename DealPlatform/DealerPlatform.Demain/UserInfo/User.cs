using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealerPlatform.Demain.UserInfo
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}