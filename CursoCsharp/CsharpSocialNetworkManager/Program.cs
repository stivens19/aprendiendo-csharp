using System;
using CsharpSocialNetworkManager.Models;
namespace CsharpSocialNetworkManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new AppManager();
            Console.WriteLine($"Bienvenido a {app.AppTitle}");

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
            foreach (var item in app.SocialNetworks)
            {
                if (item.Name.ToLower() == socialNetworkName.ToLower())
                {
                    Console.WriteLine($"Nombre: {app.GetSocialNetworkInformation(item)}");
                    
                }
            }
            foreach (var item in app.SocialNetworkWithGroups)
            {
                if (item.Name.ToLower() == socialNetworkName.ToLower())
                {
                    Console.WriteLine($"Nombre: {app.GetSocialNetworkInformation(item)}");
                }
            }
            return;
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
        }
    }
}
