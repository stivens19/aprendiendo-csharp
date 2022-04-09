using System;
using CursoCsharp.Enumerations;
namespace CursoCsharp
{
    class Program
    {
        //This is a main method
        static void Main(string[] args)
        {
            const string nombre = "Stivens"; //This is a name variable
            var apellido = "Espinoza";
            short edad = 23;
            Int16 altura = 178;
            float alturMetros = 1.78f;
            Console.WriteLine($"Hello {nombre} {apellido}");
            Console.WriteLine($"Mi nombre tiene {nombre.Length} letras");
            Console.WriteLine($"Mi edad es {edad} y mi altura es {altura} cm");
            Console.WriteLine($"Mi altura en m es {alturMetros}");

            DateTime fechaNacimiento = new DateTime(1999, 2, 28);
            Console.WriteLine($"Mi fecha de nacimiento es {fechaNacimiento.Date.ToShortDateString()}");
            Console.WriteLine($"Mi fecha de nacimiento es {fechaNacimiento.Date.ToString("Y")}");

            DateTime fechaActual = DateTime.Now;
            Console.WriteLine($"La fecha actual es: {fechaActual}");

            TimeSpan diferenciaFechas = fechaActual - fechaNacimiento;
            Console.WriteLine($"a diferencia de fechas es : {diferenciaFechas.Days/365}");

            var miGenero = Genero.Masculino;
            Console.WriteLine($"Mi genero es : {miGenero}");

            var miEstadoCivil = EstadoCivil.Soltero;
            Console.WriteLine($"Mi Estado civil es {miEstadoCivil}");

            DateTime? fechaTerminacionCurso = null;

            Console.WriteLine($"El curso termina en {fechaTerminacionCurso?.Date}");

            bool tieneMacota = false;

            Console.WriteLine($"{nombre} {(tieneMacota ? "Tiene Mascota" : "No tiene mascota")}");
        }
    }
    
}
