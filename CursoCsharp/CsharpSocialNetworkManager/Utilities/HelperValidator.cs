using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSocialNetworkManager.Utilities
{
    public static class HelperValidator
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
