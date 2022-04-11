using CoWorkingApp.Models;
using System.Linq;
using System;
using CoWorkingApp.Data.Tools;

namespace CoWorkingApp.Data
{
    public class UserData
    {
        private JsonManager<User> jsonManager;
        public UserData()
        {
            jsonManager = new JsonManager<User>();
        }

        public bool CreateAdmin()
        {
            var userCollection = jsonManager.GetCollection();

            if (!userCollection.Any(p => p.Name == "Admin" && p.LastName == "Admin" && p.Email == "Admin"))
            {
                try
                {
                    var adminUser = new User()
                    {
                        UserId = Guid.NewGuid(),
                        Name = "Admin",
                        LastName = "Admin",
                        Email = "Admin",
                        Password = EncryptData.EncryptText("password"),
                    };
                    userCollection.Add(adminUser);
                    jsonManager.SaveCollection(userCollection);
                    return true;
                }
                catch (System.Exception ex)
                {
                    return false;
                }

            }
            return true;
        }
    }
}