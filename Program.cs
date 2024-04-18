using System.Globalization;
namespace pattern_project
{
    class program
    {
        static void Main(String[] args) 
        {          
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}