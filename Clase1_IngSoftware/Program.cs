using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_IngSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            Poblacion poblacion = new Poblacion(new Perro());
            poblacion.proceso();
            poblacion.sonido("guau");
            poblacion.comunicarse();
            poblacion.sonido("woof");
            poblacion.comunicarse();

            Console.WriteLine();

            poblacion = new Poblacion(new Gato());
            poblacion.proceso();
            poblacion.sonido("miau");
            poblacion.comunicarse();

            Console.WriteLine();

            poblacion = new Poblacion(new Gallina());
            poblacion.proceso();

            Console.ReadLine();
        }
        
        public void ConfigureServices(IServiceCollection service)
        {
            service.AddSingleton<ISerVivo, Perro>();
            service.AddTransient<ISerVivo, Gato>();
            service.AddScoped<ISerVivo, Gallina>();
        }
    }
}
