using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tamagotchi;

public class Aburrido : IEstado
{
    public DateTime Inicio { get; private set; }

    public static TimeSpan IntervaloComer { get; set; } = TimeSpan.FromSeconds(8);

    public TimeSpan IntervaloAburrida => DateTime.Now - Inicio;


    public Aburrido() => Inicio = DateTime.Now;

    public void Comer(Mascota mascota)
    {
        if (IntervaloAburrida > IntervaloComer)
            mascota.Estado = new Contento();
    }

    public void Jugar(Mascota mascota)
    {
        mascota.Estado = new Contento();
    }
}
