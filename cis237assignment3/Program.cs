using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting the window size as large as it can be and setting the scroll back to be as much as possible.
            double width = (Console.LargestWindowWidth * 0.75);
            double height = (Console.LargestWindowHeight * 0.75);
            Console.SetWindowSize(Convert.ToInt16(width), Convert.ToInt16(height));
            Console.BufferHeight = Int16.MaxValue - 1;
            //Declaring a new User Interface and calling the one public method
            UserInterface ui = new UserInterface();
            ui.MainMenu();
        }
    }
}
