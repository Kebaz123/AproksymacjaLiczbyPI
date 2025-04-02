namespace aproksymacja_liczby_PI_klasa
{
    public class ClassPI
    {
        public static double oblicz_przyblizenie_PI( float n )
        {
            double x, y, PI;
            double punkty_w_cwiartce_okregu = 0;
            Random losowa_liczba = new Random();

            for( int i = 0; i < n; i++ )
            {
                x = losowa_liczba.NextDouble();
                y = losowa_liczba.NextDouble();

                if ( Math.Pow( x, 2 ) + Math.Pow( y, 2 ) <= 1 )
                {
                    punkty_w_cwiartce_okregu += 1;
                }
            }
            PI = ( punkty_w_cwiartce_okregu / n ) * 4;
            return PI;
        }
       

    }
}