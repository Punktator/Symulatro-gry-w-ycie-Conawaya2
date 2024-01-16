namespace Gra_w_życie__Conwaya;

// See https://aka.ms/new-console-template for more information

class Program
{
    internal static void Main()
    {
        uint poczatkowa_liczba_zywywch_komurek = Convert.ToUInt32(Console.ReadLine());

        List <Kordy> lista_korduw = new List<Kordy>();
        
        for (int i = 0; i < poczatkowa_liczba_zywywch_komurek; i++) 
        {
            Kordy kordy = new Kordy();
            kordy.x = Convert.ToUInt32(Console.ReadLine());
            kordy.y = Convert.ToUInt32(Console.ReadLine());

            lista_korduw.Add(kordy);
        }

        Symulator_gry_w_życie test = new(lista_korduw);

        Console.Write("Podaj agar: ");
        uint agar = Convert.ToUInt32(Console.ReadLine());

        test.CyklRzycia(agar);
    }
}



