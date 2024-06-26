namespace C42_G01_CS03
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Question 1
            //Console.WriteLine("Please Enter Your Number: ");

            //int Number = int.Parse(Console.ReadLine() ?? "0");

            //if (Number % 3 == 0 && Number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //    Console.WriteLine("No");

            #endregion



            #region Question 2
            
            Console.Write("Please Enter a Number: ");

            int Number = int.Parse(Console.ReadLine() ?? "0");

            if(Number < 0) 
            {
                Console.WriteLine("negative");
            }
            else
                Console.WriteLine("positive");

            #endregion


        }
    }
}
