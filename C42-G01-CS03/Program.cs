using Microsoft.VisualBasic;

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

            //Console.Write("Please Enter a charcter: ");

            //char alph = char.Parse(Console.ReadLine() ?? "");

            //switch (alph)
            //{
            //    case 'a' :
            //        goto case 'u';

            //    case 'e':
            //        goto case 'u';

            //    case 'i':
            //        goto case 'u';

            //    case 'o':
            //        goto case 'u';

            //    case 'u':
            //        Console.WriteLine("Vowel");
            //        break;

            //    default:
            //        Console.WriteLine("consonant");
            //        break;

            //}

            #endregion


            #region Question 6

            //Console.Write("Please Enter a Number: ");

            //int Number = int.Parse(Console.ReadLine() ?? "0");

            //for (int i = 1; i <= Number; i++)
            //    Console.Write($"{i}, ");

            #endregion


            #region Question 7

            //Console.Write("Please Enter a Number: ");

            //int Number = int.Parse(Console.ReadLine() ?? "0");

            //for (int i = 1; i <= 12; i++)
            //    Console.Write($"{i * Number} ");

            #endregion


            #region Question 8

            //Console.Write("Please Enter The End Loop Number: ");

            //int Number = int.Parse(Console.ReadLine() ?? "0");

            //for (int i = 1; i < Number; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.Write($"{i} ");
            //}

            #endregion


            #region Question 9

            //Console.Write("Please Enter two Numbers: ");

            //int Number1 = int.Parse(Console.ReadLine() ?? "0");

            //int Number2 = int.Parse(Console.ReadLine() ?? "0");

            //int pow = 1;
            //for (int i = 0; i < Number2; i++)
            //    pow *= Number1;

            //Console.WriteLine(pow);

            #endregion


            #region Question 10

            //Console.Write("Enter the marks of the five subjects: ");

            //int sum = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    sum += int.Parse(Console.ReadLine() ?? "0");
            //}
            //Console.WriteLine($"Total marks = {sum}");

            //int avg = sum / 5;

            //Console.WriteLine($"Average marks = {avg}");

            //double perc = (double)sum / 5;

            //Console.WriteLine($"percentage marks = {perc}");


            #endregion


            #region Question 11

            //Console.Write("Month Number: ");

            //int Month=int.Parse(Console.ReadLine() ?? "0");

            //if (Month == 2)
            //    Console.WriteLine(28);
            //else if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
            //    Console.WriteLine(30);
            //else
            //    Console.WriteLine(31);


            #endregion


            #region Question 12

            Console.Write("Enter a number: ");

            int Left = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter (+,-,*,/): ");

            char Sep = char.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter a number: ");

            int Right = int.Parse(Console.ReadLine() ?? "0");

            if (Sep == '+')
                Console.WriteLine(Left + Right);
            else if (Sep == '-')
                Console.WriteLine(Left - Right);
            else if (Sep == '*')
                Console.WriteLine(Left * Right);
            else
                Console.WriteLine(Left / Right);

            #endregion



        }
    }
}
