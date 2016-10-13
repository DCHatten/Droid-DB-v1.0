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
        /// as well as references to all the types of droids
        /// </summary>
        private DroidCollection droidCollection = new DroidCollection();
        //private Droid droid;
        private Protocol protocol;
        private Janitor janitor;
        private Astromech astromech;
        /// <summary>
        /// Declaring all the temporary variables that will be used to store user input prior to being passed into the individual constructors
        /// </summary>
        private string name;
        private string material;
        private string model;
        private string color;
        private decimal baseCost;
        private decimal totalCost;
        private int numberLanguages;
        private bool toolbox;
        private bool computerConnection;
        private bool arm;
        private bool trashCompactor;
        private bool vacuum;
        private bool fireExtinguisher;
        private bool numberShips;
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
            switch (choice)
            {
                case "1":
                    AddDroid();
                    break;
                case "2":
                    PrintDatabase();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Error: please select from available options");
                    MainMenu();
                    break;
            }
            MainMenu();
        }
        /// <summary>
        /// Method to add a droid to the droid collection
        /// </summary>
        private void AddDroid()
        {
            baseCost = 0m;
            totalCost = 0m;
            Console.WriteLine("Please input the Droid Designation:");
            name = Console.ReadLine();
            Console.WriteLine("Please choose the material for the Droid:");
            Console.WriteLine("1. Titanium");
            Console.WriteLine("2. Mandalorian Iron");
            Console.WriteLine("3. Ultrachrome");
            string materialChoice = Console.ReadLine();
            switch (materialChoice)
            {
                case "1":
                    material = "Titanium";
                    baseCost += 50m;
                    break;
                case "2":
                    material = "Mandalorian Iron";
                    baseCost += 100m;
                    break;
                case "3":
                    material = "Ultrachrome";
                    baseCost += 200m;
                    break;
                default:
                    Console.WriteLine("Error: please select from available options");
                    AddDroid();
                    break;
            }
            Console.WriteLine("Please choose the color for the Droid:");
            Console.WriteLine("1. Raw Metal");
            Console.WriteLine("2. Red");
            Console.WriteLine("3. Blue");
            string colorChoice = Console.ReadLine();
            switch (colorChoice)
            {
                case "1":
                    color = "Raw Metal";
                    baseCost += 0m;
                    break;
                case "2":
                    color = "Red";
                    baseCost += 10m;
                    break;
                case "3":
                    color = "Blue";
                    baseCost += 10m;
                    break;
                default:
                    Console.WriteLine("Error: please select from available options");
                    AddDroid();
                    break;
            }
            Console.WriteLine("Please choose the type of Droid you wish to add:");
            Console.WriteLine("1. Protocol Droid");
            Console.WriteLine("2. Utility Droid");
            string modelChoice = Console.ReadLine();
            switch (modelChoice)
            {
                case "1":
                    model = "Protocol";
                    baseCost += 500m;
                    AddProtocolDroid();
                    break;
                case "2":
                    AddUtilityDroid();
                    break;
                default:
                    Console.WriteLine("Error: please select from available options");
                    AddDroid();
                    break;
            }
        }
        private void AddProtocolDroid()
        {
            protocol = new Protocol();
            numberLanguages = 0;
            Console.WriteLine("Please choose the number of languages spoken:");
            Console.WriteLine("1. 6 Million");
            Console.WriteLine("2. 7 Million");
            Console.WriteLine("3. 8 Million");
            string languageChoice = Console.ReadLine();
            switch (languageChoice)
            {
                case "1":
                    numberLanguages = 6;
                    break;
                case "2":
                    numberLanguages = 7;
                    break;
                case "3":
                    numberLanguages = 8;
                    break;
                default:
                    Console.WriteLine("Error: please select from available options");
                    AddProtocolDroid();
                    break;
            }
            protocol.NumberLanguages = numberLanguages;
            totalCost = protocol.CalculateTotalCost();
            droidCollection.AddProtocolDroid(name, model, color, material, baseCost, totalCost, numberLanguages);
        }
        private void AddUtilityDroid()
        {
            Console.WriteLine("Please choose the number of languages spoken:");
            Console.WriteLine("1. 6 Million");
            Console.WriteLine("2. 7 Million");
            Console.WriteLine("3. 8 Million");
        }
        private void AddAstromechDroid()
        {
            astromech = new Astromech();
            Console.WriteLine("Please choose the number of languages spoken:");
            Console.WriteLine("1. 6 Million");
            Console.WriteLine("2. 7 Million");
            Console.WriteLine("3. 8 Million");

            
            totalCost = astromech.CalculateTotalCost();
        }
        private void AddJanitorDroid()
        {
            janitor = new Janitor();
            Console.WriteLine("Please choose the number of languages spoken:");
            Console.WriteLine("1. 6 Million");
            Console.WriteLine("2. 7 Million");
            Console.WriteLine("3. 8 Million");


            totalCost = janitor.CalculateTotalCost();
        }
        /// <summary>
        /// Method for printing the droid collection to the screen
        /// </summary>
        private void PrintDatabase()
        {
            //Variable for holding the list
            string allOutput = "";
            int i = 1;
            //Loop which will load the list into the string variable
            foreach (Droid droid in droidCollection.droidList) 
            {
                //Check to make sure we have data to print
                if (droid != null)
                {
                    allOutput += i.ToString() + ". " + droid.ToString() + Environment.NewLine;
                    i++;
                }
            }
            //Write the string to the screen
            Console.WriteLine(allOutput);                
        }
    }
}
