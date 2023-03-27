using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tamagotchi;

public class Hambriento : IEstado
{

    public void Comer(Mascota mascota)
    {
        mascota.Estado = new Contento();
    }

    public void Jugar(Mascota mascota)
    {

    }
}
