using System.Globalization;
namespace pattern_project
{
    class program
    {
        static void Main(String[] args)
        {
            int n = 6; // Number of rows in the pattern
            ////int start = 1; // Initial value for the pattern
            ////int step = 2;
            for (int i = 0; i < n; i+=2)
            {
                for (int j = 0; j <= i; j++)
                {
                   
                    Console.Write("*");
                    ////Console.Write(start + j * step + " ");
                }
                
                ////start += step * (i + 1);
                Console.WriteLine();

            }
            if (n == 9)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();
        }

    }
}