namespace Consola
{
    using System;
    using Newtonsoft.Json;

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(JsonConvert.SerializeObject(ObtenerUsuario()));
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static Usuario ObtenerUsuario()
        {
            return new Usuario
            {
                Id = 9,
                Nombre = "Elba Bozo",
                FechaNacimiento = new DateTime(1992, 05, 25)
            };
        }
    }
}