using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpSocialNetworkManager.Models
{
    class AppManager
    {
        public string AppTitle { get; set; }
        public List<SocialNetwork> SocialNetworks { get; set; }
        public List<SocialNetworkWithGroups> SocialNetworkWithGroups { get; set; }
        public AppManager()
        {
            AppTitle = "Administrador de Redes Sociales";
            SocialNetworks = new List<SocialNetwork>();
            SocialNetworkWithGroups = new List<SocialNetworkWithGroups>();
            InitializeSocialNetworks();
        }
        public void InitializeSocialNetworks()
        {
            SocialNetworks.Add(new SocialNetwork()
            {
                Name="Twitter",
                Description="Red social para intercambiar mensajes cortos",
                Users=new List<User>(),
                DateCreated=new DateTime(2008,1,20)
            });
            SocialNetworks.Add(new SocialNetwork()
            {
                Name = "Instagram",
                Description = "Red social para intercambiar fotos y videos",
                Users = new List<User>(),
                DateCreated = new DateTime(2010, 5, 2)
            });

            SocialNetworkWithGroups.Add(new SocialNetworkWithGroups()
            {
                Name = "Facebook",
                Description = "Red social para muchas cosas",
                Users = new List<User>(),
                Groups = new List<string>() { "Programacion","Diseño", "Redes" },
                DateCreated = new DateTime(2007, 1, 2)
            });
        }
        //<T> para trabajar con generics
        public string GetSocialNetworkInformation<T>(T socialNetwork)
        {
            var socialNetworkItem = socialNetwork as SocialNetwork;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Nombre: {socialNetworkItem.Name} \n");
            stringBuilder.Append($"Descripcion: {socialNetworkItem.Description} \n");
            stringBuilder.Append($"Año: {socialNetworkItem.DateCreated.Year}");
            if (socialNetworkItem is SocialNetworkWithGroups)
            {
                var socialNetworkWithGroupsItem = socialNetwork as SocialNetworkWithGroups;
                stringBuilder.AppendLine($"Grupos: {string.Join(",",socialNetworkWithGroupsItem.Groups)}");
            }

            return stringBuilder.ToString();
        }
    }
}
