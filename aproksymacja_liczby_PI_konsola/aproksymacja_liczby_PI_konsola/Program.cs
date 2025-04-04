
using aproksymacja_liczby_PI_klasa;

double PI_wynik=0;
while (PI_wynik == 0)
{
    Console.WriteLine("Podaj liczbe punktow do wylosowania");
    string ciag_znakow_n = Console.ReadLine();

    if (int.TryParse(ciag_znakow_n, out int n))
    {
        if (n > 0)
        {
            PI_wynik = ClassPI.oblicz_przyblizenie_PI(n);
            Console.WriteLine("Przyblizenie liczby PI wynosi "+PI_wynik);
            Console.WriteLine();

            bool decyzja_o_kontynuacji=true;
            while (decyzja_o_kontynuacji)
            {
                Console.WriteLine("Czy chcesz wylosowac kolejna liczbe? (T/N): ");
                string wybor_kontynuacja = Console.ReadLine();
                switch (wybor_kontynuacja.ToUpper())
                {
                    case "T":
                        PI_wynik = 0;
                        decyzja_o_kontynuacji = false;
                        break;
                    case "N":
                        Console.WriteLine("Dziekuje za skorzystanie z programu");
                        decyzja_o_kontynuacji = false;
                        break;
                    default:
                        Console.WriteLine("Nieprawidlowy wybor");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Ujemna liczba");
        }
    }
    else
    {
        Console.WriteLine("Nieprawidlowa liczba");
    }
    Console.WriteLine();
}

