using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
        /// <summary>
        /// Declaring a droid collection item to reference the droid collection list
        /// </summary>
        private DroidCollection droidCollection;
        /// <summary>
        /// Method for creating a menu to select from various options
        /// </summary>
        public void MainMenu()
        {
            Console.WriteLine("Please select what you would like to do:");
            Console.WriteLine("1. Add a new droid to the database");
            Console.WriteLine("2. Print the full list of current droids");
            Console.WriteLine("3. Exit");
            string choice = Console.ReadLine();
            while (choice != "3")
            {
                switch (choice)
                {
                    case "1":
                        AddDroid();
                        MainMenu();
                        return;
                    case "2":
                        PrintDatabase();
                        MainMenu();
                        return;
                    default:
                        Console.WriteLine("Error: please select from available options");
                        MainMenu();
                        return;
                }
            }
            Environment.Exit(0);
        }
        /// <summary>
        /// Method to add a droid to the droid collection
        /// </summary>
        private void AddDroid()
        {
            Console.WriteLine("Please choose the type of Droid you wish to add:");
            Console.WriteLine("1. Protocol Droid");
            Console.WriteLine("2. Janitor Droid");
            Console.WriteLine("3. Astromech Droid");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    droidCollection.AddProtocolDroid();
                    return;
                case "2":
                    droidCollection.AddJanitorDroid();
                    return;
                case "3":
                    droidCollection.AddAstromechDroid();
                    return;
                default:
                    Console.WriteLine("Error: please select from available options");
                    AddDroid();
                    return;
            }
        }
        /// <summary>
        /// Method for printing the droid collection to the screen
        /// </summary>
        private void PrintDatabase()
        {
            //Variable for holding the list
            string allOutput = "";
            //Loop which will load the list into the string variable
            foreach (Droid droid in droidCollection.droidList) 
            {
                //Check to make sure we have data to print
                if (droid != null)
                {
                    allOutput += droid.ToString() + Environment.NewLine;
                }
            }
            //Write the string to the screen
            Console.WriteLine(allOutput);                
        }
    }
}
