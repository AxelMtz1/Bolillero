namespace Biblioteca.Interfaz;

public class Random
{
public class Random : IRandom
{
    public int randomizer(Bolillero bolillero)
    {
        Random rnd = new(DateTime.Now.Millisecond);
        int randomizerValue = rnd.Next(0, bolillero.Bolillas.Count);
        int random = bolillero.Bolillas[randomizerValue];
        return random;
    }
}
}
