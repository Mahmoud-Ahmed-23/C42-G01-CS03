using Microsoft.VisualBasic;
using System.Text;

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

            //Console.Write("Enter a number: ");

            //int Left = int.Parse(Console.ReadLine() ?? "0");

            //Console.Write("Enter (+,-,*,/): ");

            //char Sep = char.Parse(Console.ReadLine() ?? "0");

            //Console.Write("Enter a number: ");

            //int Right = int.Parse(Console.ReadLine() ?? "0");

            //if (Sep == '+')
            //    Console.WriteLine(Left + Right);
            //else if (Sep == '-')
            //    Console.WriteLine(Left - Right);
            //else if (Sep == '*')
            //    Console.WriteLine(Left * Right);
            //else
            //    Console.WriteLine(Left / Right);

            #endregion


            #region Question 13

            //Console.Write("Enter a Word: ");

            //string word = Console.ReadLine() ?? "No Data";

            //for (int i = word.Length - 1; i >= 0; i--)
            //    Console.Write(word[i]);


            #endregion


            #region Question 14

            //Console.Write("Enter a Word: ");

            //string Number = Console.ReadLine() ?? "No Data";

            //for (int i = Number.Length - 1; i >= 0; i--)
            //    Console.Write(Number[i]);





            #endregion


            #region Question 15

            //Console.Write("starting number of range: ");

            //int Start = int.Parse(Console.ReadLine() ?? "0");

            //Console.Write("Ending number of range: ");

            //int End = int.Parse(Console.ReadLine() ?? "0");

            //Console.WriteLine($"The prime number between {Start} and {End} are: ");
            //for (int i = Start; i <= End; i++)
            //{
            //    bool flag = true;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            flag = false;
            //            break;
            //        }
            //    }
            //    if (flag && i > 1) 
            //        Console.Write($"{i} ");
            //}


            #endregion


            #region Question 16

            //Console.Write("Enter a number to convert: ");

            //int Number = int.Parse(Console.ReadLine() ?? "0");

            //StringBuilder Binary = new StringBuilder();
            //while (Number != 0) 
            //{
            //    if (Number % 2 == 0) 
            //    {
            //        Binary.Insert(0, "0");
            //        Number /= 2;
            //    }
            //    else 
            //    {
            //        Binary.Insert(0, "1");
            //        Number /= 2;
            //    }

            //}

            //Console.WriteLine(Binary);
            #endregion


            #region Question 17

            //Console.WriteLine("Enter Three points (x,y): ");

            //int[] X = new int[3];

            //int[] Y = new int[3];

            //bool flayX = true;
            //bool flayY = true;

            //for (int i = 0; i < 3; i++)
            //{
            //    X[i] = int.Parse(Console.ReadLine() ?? "0");

            //    Y[i] = int.Parse(Console.ReadLine() ?? "0");

            //    if (i != 0 && X[i] != X[i - 1])
            //        flayX = false;

            //    if (i != 0 && Y[i] != Y[i - 1])
            //        flayY = false;
            //}

            //if (flayX || flayY)
            //    Console.WriteLine("these points 'lie on a single straight line'");
            //else
            //    Console.WriteLine("these points 'Not lie on a single straight line'");



            #endregion


            #region Question 18

            //Console.WriteLine("Enter the hour Works: ");

            //int F_Hour = int.Parse(Console.ReadLine() ?? "0");

            //int L_Hour = int.Parse(Console.ReadLine() ?? "0");

            //if (L_Hour < 3)
            //    Console.WriteLine("they are considered highly efficient.");
            //else if (L_Hour < 4)
            //    Console.WriteLine("they are instructed to increase their speed.");
            //else if (L_Hour < 5)
            //    Console.WriteLine("they are provided with training to enhance their speed.");
            //else
            //    Console.WriteLine("they are required to leave the company.");


            #endregion


            #region Question 19

            Console.Write("Enter the size: ");

            int Size = int.Parse(Console.ReadLine() ?? "0");

            int[,] arr = new int[Size, Size];

            int f = 1;
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    arr[i, j] = f++;
                }
            }
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine(" ");
            }

            #endregion

        }
    }
}
