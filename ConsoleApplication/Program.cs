using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // store two variables
            string name = "Arturo Perez";
            string location = "California";

            // input request
            Console.Write("enter name:");
            string namee = Console.ReadLine();

            Console.Write("enter location: ");
            string locationn = Console.ReadLine();

            // output name and location from two variables
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I'm from { location}");

            // output date
            var currentDate = DateTime.Now;
            Console.WriteLine($"Today is {currentDate.ToString("d")}");

            // variable count down and current date
            DateTime daysLeft = DateTime.Parse("12/25/2020 12:00:01 AM");
            DateTime startDate = DateTime.Now;

            // timer "count down"
            TimeSpan t = daysLeft - startDate;
            string countDown = string.Format("{0} Days, {1} Hours, {2} Minutes, {3} Seconds til launch.", t.Days, t.Hours, t.Minutes, t.Seconds);
            Console.WriteLine($"Days until Christmas {countDown}");

            // program example 2.1 
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            // input
            Console.Write("Enter the width and press <Enter>");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Enter the height and press <Enter>");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            // calculate area
            Console.Write("Results <>");
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            // use readkey
            Console.WriteLine("Press any key to end: ");
            Console.ReadKey();

        }
    }
}
