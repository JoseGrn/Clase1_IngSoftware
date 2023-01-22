using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_IngSoftware
{
    public interface ISerVivo
    {
        ServiceLifetime serviceLifetime { get; }
        void emitirSonido();
        void setSonido(string sonido);
    }
}
