using CoWorkingApp.Data;

namespace CoWorkingApp.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string roleSelected = "";
            Console.WriteLine("Welcome to CoWorkingApp");
            Console.WriteLine("Please select your role");
            while (roleSelected != "1" && roleSelected != "2")
            {
                Console.WriteLine("1=Admin, 2=Usuario");
                roleSelected = Console.ReadLine();
            }
            switch (roleSelected)
            {
                case "1":
                    {
                        string menuAdminSelected = "";
                        while (menuAdminSelected != "1" && menuAdminSelected != "2")
                        {
                            Console.WriteLine("1=Administracion de puestos, 2=Administracion de Usuarios");
                            menuAdminSelected = Console.ReadLine();
                            switch (menuAdminSelected)
                            {
                                case "1":
                                    {
                                        string menuPuestosSelected = "";
                                        while (menuPuestosSelected != "1" && menuPuestosSelected != "2" && menuPuestosSelected != "3" && menuPuestosSelected != "4")
                                        {
                                            Console.WriteLine("Administracion de puestos");
                                            Console.WriteLine("1=Crear puesto, 2=Editar puesto, 3=Eliminar puesto,4=Bloquear puesto");
                                            menuPuestosSelected = Console.ReadLine();
                                            switch (menuPuestosSelected)
                                            {
                                                case "1":
                                                    {
                                                        Console.WriteLine("Crear puesto");
                                                        break;
                                                    }
                                                case "2":
                                                    {
                                                        Console.WriteLine("Editar puesto");
                                                        break;
                                                    }
                                                case "3":
                                                    {
                                                        Console.WriteLine("Eliminar puesto");
                                                        break;
                                                    }
                                                case "4":
                                                    {
                                                        Console.WriteLine("Bloquear puesto");
                                                        break;
                                                    }
                                                default:
                                                    break;
                                            }
                                        }


                                        break;
                                    }
                                case "2":
                                    {
                                        string menuPuestosSelected = "";
                                        while (menuPuestosSelected != "1" && menuPuestosSelected != "2" && menuPuestosSelected != "3" && menuPuestosSelected != "4")
                                        {
                                            Console.WriteLine("Administracion de puestos");
                                            Console.WriteLine("1=Crear puesto, 2=Editar puesto, 3=Eliminar puesto,4=Bloquear puesto");
                                            menuPuestosSelected = Console.ReadLine();
                                            switch (menuPuestosSelected)
                                            {
                                                case "1":
                                                    {
                                                        Console.WriteLine("Crear puesto");
                                                        break;
                                                    }
                                                case "2":
                                                    {
                                                        Console.WriteLine("Editar puesto");
                                                        break;
                                                    }
                                                case "3":
                                                    {
                                                        Console.WriteLine("Eliminar puesto");
                                                        break;
                                                    }
                                                case "4":
                                                    {
                                                        Console.WriteLine("Bloquear puesto");
                                                        break;
                                                    }
                                                default:
                                                    break;
                                            }
                                        }
                                        break;
                                    }
                            }
                        }
                        break;
                    }
                case "2":
                    {
                        string menuUserSelected = "";
                        while (menuUserSelected != "1" && menuUserSelected != "2")
                        {
                            Console.WriteLine("1=Reservar un puesto, 2=Cancelar una reserva");
                            menuUserSelected = Console.ReadLine();
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}