using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hur många X per grupp?");
        int xPergrupp = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hur många O per grupp?");
        int oPergrupp = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hur många O-mönster per rad?");
        int oMönsterPerRad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hur många rader");
        int antalRader = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(antalRader);

        for (int i = 0; i < antalRader; i++)
        {
            for (int n = 0; n < oMönsterPerRad + 1; n++)
            {
                for (int j = 0; j < xPergrupp; j++)
                {
                    Console.Write("X");
                }

                if ((n) < oMönsterPerRad)
                {
                    Console.Write("-");
                    for (int l = 0; l < oPergrupp; l++)
                    {
                        Console.Write("O");
                    }
                    Console.Write("-");
                }

            }
            Console.WriteLine();

        }

    }
}
