namespace pattern_project
{
    class program
    {
        static void Main(String[] args)
        {
            for (int i = 1; i <= 7; i++)
            {
                for (int j =1; j <=i; j++)
                {
                    Console.Write("&");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
    //second patter
    //class program
    //{
    //    static void Main(String[] args)
    //    {
    //        for (int i = 1; i <= 7; i++)
    //        {
    //            for (int j = i; j <= 7; j++)
    //            {
    //                Console.Write("");
    //            }
    //            Console.WriteLine();
    //        }
    //        Console.ReadLine();
    //    }

    //}
}