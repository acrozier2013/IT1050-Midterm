using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050_MIDTERM
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create an infinite while loop.Use a Boolean variable called keepLooping that set to true in the loop’s termination condition.
            //Hint: Use CTRL+C or Debug -> Terminate All to end the program. 

            //int i = 1;
            //Boolean keepLooping = true;

            //while (keepLooping)
            //{
            //    if (i >= 1)
            //    {
            //        keepLooping = true;
            //        i++;
            //        Console.WriteLine(i);
            //    }
            //}


            //2.Write a while loop to prints 2 through 128 in brackets, each on a new line.You should initialize your loop control variable to 2.
            //Output the value of the loop control variable each time through the loop.

            //[2]
            //[4]
            //[8]
            //[16]
            //[32]
            //[64]
            //[128]

            //int i;
            //i = 2;

            //while (i < 129)
            //{
            //    Console.WriteLine("["+i+"]");
            //    i = i * 2;
            //}


            //3.Write a for loop that prints 49 through 1 separated by a comma.Note, you will need to use a condition inside of the loops so it does not 
            //print the comma the last time through(no newlines – although there should be a newline after 1.You need to be a little tricky with the newlines).
            //49, 48, 47, …, 3, 2, 1

            //int i;

            //for (i = 49; i > 0; i = i - 1)
            //{

            //    if (i != 1)
            //    {
            //        Console.Write(i + ", ");
            //    }
            //    else
            //    {
            //        Console.Write(i);
            //        Console.WriteLine("");
            //    }
            //}


            //4.Write a while loop that prints all odd numbers 1 through 21, each separated by three spaces(no newlines except after the last number).
            //1   3   5   7   9   11   13   15   17   19   21

            //int i;
            //i = 1;
            //while (i < 22)
            //{
            //    Console.Write(i + "   ");
            //    i = i + 2;
            //    if (i > 21)
            //    {
            //        Console.WriteLine("");
            //    }
            //}


            //5.Implement the following code using a while loop.In a comment in your code, explain the difference in output between the do -while and while.
            //int n = 8;
            //int i = 10; // initialize
            //do
            //{
            //    Console.Write("*");
            //    i++; // update!
            //} while (i < n); // test condition

            //in a do...while loop, the condition is checked after the loop has already been ran once, and in a while loop the condition is checked prior to 
            //the loop running. Thus, a do...while loop will be executed at least once regardless of the condition being met, but in a while loop, the condition
            //must be met for the loop to execute.
            //int n = 8;
            //int i = 10;

            //while (i < n)
            //{
            //    Console.WriteLine("*");
            //    i++;
            //}

            //6.Use and and or(&& and ||) to write an if statement that outputs “Let’s go outside!” when both Boolean values are false.
            //boolean icyRain;
            //boolean tornadoWarning;

            //Boolean icyRain = false;
            //Boolean tornadoWarning = false;

            //if(icyRain == false && tornadoWarning == false)
            //{
            //    Console.WriteLine("Let's go outside!");
            //}

            //7.Extra Credit: Use nested loops to print the following to the console:

            //123454321
            // 1234321
            //  12321
            //   121
            //    1

            //int numberoflayer = 5;
            //int Space;
            //int Number;

            //for (int i = 1; i <= numberoflayer; i++) // Total number of layer for pramid  
            //{
            //    for (Space = 1; Space <= (numberoflayer - i); Space++) // Loop For Space  
            //        Console.Write(" ");
            //    for (Number = 1; Number <= i; Number++) //increase the value  
            //        Console.Write(Number);
            //    for (Number = (i - 1); Number >= 1; Number--) //decrease the value  
            //        Console.Write(Number);
            //    Console.WriteLine();
            //}
        }
    }
}
