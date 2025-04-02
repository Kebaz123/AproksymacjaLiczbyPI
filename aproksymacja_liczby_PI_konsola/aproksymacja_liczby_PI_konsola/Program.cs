
using aproksymacja_liczby_PI_klasa;
double PI_wynik;

Console.WriteLine("Podaj liczbe punktow do wylosowania");
    string ciag_znakow_n=Console.ReadLine();
   

    if(int.TryParse(ciag_znakow_n,out int n))
    {   
        if(n>0) {
        PI_wynik = ClassPI.oblicz_przyblizenie_PI(n);
        Console.WriteLine(PI_wynik);
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
