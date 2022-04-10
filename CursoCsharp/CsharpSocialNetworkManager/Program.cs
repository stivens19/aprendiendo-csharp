using System;
using CsharpSocialNetworkManager.Models;
using System.Linq;
using CsharpSocialNetworkManager.Utilities.Log;

namespace CsharpSocialNetworkManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new AppManager(new LogJson());
            Console.WriteLine($"Bienvenido a {app.AppTitle}");

            while (true)
            {
                Console.WriteLine("Redes sociales disponibles:");
                foreach (var item in app.SocialNetworks)
                {
                    Console.WriteLine($"{item.Name}");
                }
                foreach (var item in app.SocialNetworkWithGroups)
                {
                    Console.WriteLine($"{item.Name}");
                }

                Console.WriteLine("Escriba el nombre de la red social a ingresar:");
                string socialNetworkName = Console.ReadLine();
                //foreach (var item in app.SocialNetworks.Concat(app.SocialNetworkWithGroups))
                //{
                //    if (item.Name.ToLower() == socialNetworkName.ToLower())
                //    {
                //        Console.WriteLine($"Nombre: {app.GetSocialNetworkInformation(item)}");

                //    }
                //}
                var SocialNetworkSelected = app.SocialNetworks.Concat(app.SocialNetworkWithGroups).FirstOrDefault(p =>
                (p.Name.ToLower() == socialNetworkName));

                Console.Write($"Nombre: {app.GetSocialNetworkInformation(SocialNetworkSelected)}");
                Console.WriteLine();
                Console.WriteLine("1=Agregar nuevo usuario 2=para estadisticas");
                var optionSelected = int.Parse(Console.ReadLine());
                switch (optionSelected)
                {
                    case 1:
                        {
                            Console.WriteLine("Por favor ingrese su nombre:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Por favor ingrese su email:");
                            string email = Console.ReadLine();
                            Console.WriteLine("Por favor ingrese su edad:");
                            short age = short.Parse(Console.ReadLine());

                            var user = new User();
                            user.Name = name;
                            user.Email = email;
                            user.Age = age;

                            if (!user.IsValid(false))
                            {
                                Console.WriteLine("Los datos del usuario no son validos");
                                return;
                            }
                            Console.WriteLine($"Bienvenido {user.Name} con correo " +
                                $"{user.Email} de edad {user.Age} activo = {user.IsActive} fecha {user.DateCreated}");

                            if(SocialNetworkSelected!=null)
                            {
                                int indexElement = app.SocialNetworks.IndexOf(SocialNetworkSelected);
                                app.SocialNetworks[indexElement].Users.Add(user);
                            }
                        }
                        break;
                    case 2:
                        {
                            if (SocialNetworkSelected != null)
                                Console.WriteLine(app.GetSocialNetworkStats(SocialNetworkSelected));
                        }
                        break;
                    default:
                        break;
                }
               
            }
        }
    }
}
