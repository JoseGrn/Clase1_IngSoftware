using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Clase1_IngSoftware
{
    internal class Perro : ISerVivo
    {
        private string sonido;

        public ServiceLifetime serviceLifetime => ServiceLifetime.Scoped;

        public void emitirSonido()
        {
            Console.WriteLine(sonido);
        }

        public void setSonido(string sonido)
        {
            this.sonido = sonido;
        }
    }

    internal class Gato : Perro
    {
    }

    internal class Gallina : Perro
    {
    }
}
