using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Consola
{
    class Program
    {
        private static IRepositorioGanadero _repositorioGanadero = new RepositorioGanadero(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddGanadero();

        }

        private static void AddGanadero()
        {
            var ganadero = new Ganadero
            {
                Nombres = "Martha",
                Apellidos = "Leyton",
                NumeroTelefono = "3165434131",
                Correo = "mleyton7@gmail.com",
                Contrasena = "123456",
                Latitud = 4554,
                Longitud = 5445
            } ;
            _repositorioGanadero.AddGanadero(ganadero);
        }

    }
}
