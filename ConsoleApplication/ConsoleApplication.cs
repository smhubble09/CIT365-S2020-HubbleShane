using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class ConsoleApplication
    {
        static void Main(string[] args)
        {
            string name = "Shane Hubble";
            string location = "Utah";
            DateTime today = DateTime.Now;
            DateTime christmas = DateTime.Parse("12/25/2020");
            double daysTilChristmas = Math.Round((christmas - today).TotalDays);

            //Write output
            Console.WriteLine($"My name is {name}, I am from {location}.");
            Console.WriteLine(today.ToString("MM/dd/yyyy"));
            Console.WriteLine($"There are {daysTilChristmas} days until Christmas.");


            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //Get width and hight of window
            Console.WriteLine("Please input window Width in feet");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please input window Height in feet");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            //Calculate length of wood and area of glass
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            //Write output
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            //Pause console. Press any key to continue
            Console.ReadKey();

        }
    }
}
