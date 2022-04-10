using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSocialNetworkManager.Models
{
    class SocialNetworkWithGroups : SocialNetwork
    {
        public List<string> Groups { get; set; }
    }
}
