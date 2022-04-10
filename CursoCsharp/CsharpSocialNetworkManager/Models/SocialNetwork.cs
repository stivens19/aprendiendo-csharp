using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSocialNetworkManager.Models
{
    class SocialNetwork
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<User> Users { get; set; }
        public DateTime DateCreated { get; set; }
        
    }
}
