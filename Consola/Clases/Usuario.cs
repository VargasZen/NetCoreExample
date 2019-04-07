namespace Consola
{    
    using System;

    [Serializable]
    public class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public TimeSpan Edad { get; set; }
    }
}