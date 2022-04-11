using CsharpSocialNetworkManager.Utilities.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpSocialNetworkManager.Models
{
    class AppManager
    {
        public string AppTitle { get; set; }
        public List<SocialNetwork> SocialNetworks { get; set; }
        public List<SocialNetworkWithGroups> SocialNetworkWithGroups { get; set; }
        public ILog<string> log { get; set; }
        public AppManager(ILog<string> logger)
        {
            log = logger;
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
            log.SaveLog("InitializeSocialNetworks");
        }
        //<T> para trabajar con generics
        public string GetSocialNetworkInformation<T>(T socialNetwork)
        {
            if (socialNetwork == null) return "";
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
            log.SaveLog("GetSocialNetworkInformation");
            return stringBuilder.ToString();
        }
        public string GetSocialNetworkStats<T>(T socialNetwork)
        {

            if (socialNetwork == null) return "";
            var socialNetworkItem = socialNetwork as SocialNetwork;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Cantidad de usuarios: {socialNetworkItem.Users.Count} \n");
            stringBuilder.Append($"Proemdio edad: {socialNetworkItem.Users.Average(p=>p.Age)} \n");
            stringBuilder.Append($"El usuario de mas edad tiene: {socialNetworkItem.Users.Max(p=>p.Age)}");
            stringBuilder.Append($"El usuario de menor edad tiene: {socialNetworkItem.Users.Min(p => p.Age)}");
            if (socialNetworkItem is SocialNetworkWithGroups)
            {
                var socialNetworkWithGroupsItem = socialNetwork as SocialNetworkWithGroups;
                stringBuilder.AppendLine($"Cantidad de Grupos: {socialNetworkWithGroupsItem.Groups.Count}");
            }

            log.SaveLog("GetSocialNetworkStats");
            
            return stringBuilder.ToString();
        }
    }
}
