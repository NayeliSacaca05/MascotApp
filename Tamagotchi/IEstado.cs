using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tamagotchi;

public interface IEstado
{
    public void Jugar(Mascota mascota);
    public void Comer(Mascota mascota);

}
