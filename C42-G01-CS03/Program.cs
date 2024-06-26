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

            //Console.Write("Please Enter a Number: ");

            //int Number = int.Parse(Console.ReadLine() ?? "0");

            //if(Number < 0) 
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //    Console.WriteLine("positive");

            #endregion



            #region Question 3

            //int max = int.MinValue; int min = int.MaxValue;

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Please Enter the {i + 1}'s Number: ");

            //    int Number = int.Parse(Console.ReadLine() ?? "0");



            //    if (Number > max)
            //        max = Number;

            //    if (min > Number)
            //        min = Number;
            //}

            //Console.WriteLine($"Max Element = {max}");

            //Console.WriteLine($"Min Element = {min}");

            #endregion



            #region Question 4

            //Console.Write("Please Enter a Number: ");

            //int Number = int.Parse(Console.ReadLine() ?? "0");

            //if(Number %2 == 0)
            //    Console.WriteLine("Number is Even");
            //else
            //    Console.WriteLine("Number is Odd");

            #endregion


            #region Question 5

            Console.Write("Please Enter a charcter: ");

            char alph = char.Parse(Console.ReadLine() ?? "");

            switch (alph)
            {
                case 'a' :
                    goto case 'u';

                case 'e':
                    goto case 'u';

                case 'i':
                    goto case 'u';

                case 'o':
                    goto case 'u';

                case 'u':
                    Console.WriteLine("Vowel");
                    break;

                default:
                    Console.WriteLine("consonant");
                    break;

            }

            #endregion




        }
    }
}
