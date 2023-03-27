using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tamagotchi;

public class Contento : IEstado
{
    public void Comer(Mascota mascota)
    {
        mascota.IncrementarNivel(1);
    }

    public void Jugar(Mascota mascota)
    {
        mascota.IncrementarNivel(2);
    }
}
