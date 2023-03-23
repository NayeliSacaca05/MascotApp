namespace Tamagotchi;

public class Mascota
{
    public int Nivel { get; private set; }
    public IEstado Estado { get; internal set; }

    public Mascota(int nivel, IEstado estado)
    {
        Nivel = nivel;
        Estado = estado;
    }

    public void Comer(Mascota mascota)
    {

    }

    public void Jugar(Mascota mascota)
    {

    }
}

