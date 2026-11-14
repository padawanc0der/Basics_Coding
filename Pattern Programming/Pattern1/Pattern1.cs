using System;
class Program
{
    static void Main()
    {
        int r = 5;
        int c = 5;

        for( int i = 0; i < r; i++)
        {
            for ( int j = 0; j < c; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
