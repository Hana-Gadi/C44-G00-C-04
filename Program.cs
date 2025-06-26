using System;
using System.Collections.Immutable;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Create a program that asks the user to input three points(x1, y1), (x2, y2), and(x3, y3), and determines whether these points lie on a single straight line.
            //Console.WriteLine("Please inter the first point (x1,y1) :");
            //int.TryParse(Console.ReadLine(), out int x1);
            //int.TryParse(Console.ReadLine(), out int y1);
            //Console.WriteLine("Please inter the second point (x2,y2) :");
            //int.TryParse(Console.ReadLine(), out int x2);
            //int.TryParse(Console.ReadLine(), out int y2);
            //Console.WriteLine("Please inter the third point (x3,y3) :");
            //int.TryParse(Console.ReadLine(), out int x3);
            //int.TryParse(Console.ReadLine(), out int y3);
            //double area = 0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
            //if (area==0)
            //    Console.WriteLine("The points lie on a single straight line.");
            //else
            //    Console.WriteLine("The points does not lie on a single straight line.");
            #endregion

            #region 2- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task.A worker's efficiency level is determined 
            //Console.WriteLine("Please enter the total hours: ");
            //int.TryParse(Console.ReadLine(), out int hours);
            //if (hours >= 2 && hours < 3)
            //{
            //    Console.WriteLine(" highly efficient.");
            //}
            //else if (hours >= 3 && hours < 4)
            //{
            //    Console.WriteLine("instructed to increase their speed.");
            //}
            //else if (hours >= 4 && hours < 5)
            //{
            //    Console.WriteLine("provided with training to enhance their speed.");
            //}
            //else {
            //    Console.WriteLine("required to leave the company.");
            //        }
            #endregion

            #region 20- Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] elements = { 1, 3, 5, 2, 8 };
            //int sum = 0;
            //for (int i = 0; i < elements.Length; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine($"The sum is: {sum}");
            #endregion

            #region 21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] arr1 = { 1, 4, 9 };
            //int[] arr2= {2, 5, 3};
            //int[] arr3 = arr1.Concat(arr2).ToArray();
            //Array.Sort(arr3);
            //foreach (int item in arr3)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region write a program find the longest distance between Two equal cells.
            //Console.WriteLine("Enter the first cell: ");
            //int.TryParse(Console.ReadLine(), out int firstCell);
            //Console.WriteLine("Enter the last cell: ");
            //int.TryParse(Console.ReadLine(), out int lastCell);
            //int count = 0;
            //for (int i = firstCell+1; i < lastCell; i++) {
            //    count = count + 1;
            //}
            //Console.WriteLine($"the longest distance is: {count}");
            #endregion

            #region 26- Given a list of space separated words, reverse the order of the words.
            //string text = "this is a test";
            //string[] arrtext=text.Split(" ");
            //for(int i = arrtext.Length -1; i >=0; i--)
            //{
            //    Console.WriteLine(arrtext[i]);
            //}
            #endregion

        }
    }
}
