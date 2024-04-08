namespace Biblioteca;

public class Bolillero
{
    private List<int> bolillas;

    public Bolillero(int cantidadBolillas)
    {
        bolillas = new List<int>();

        for (int i = 0; i <= cantidadBolillas; i++)

        {
            bolillas.Add(i);
        }
    }
}
