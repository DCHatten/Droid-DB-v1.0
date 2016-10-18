using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// David Hatten
/// User interface class which pulls data from the user, calls methods from the other classes to
/// process/manipulate that data, and provides feedback to the user.
/// </summary>
namespace cis237assignment3
{
    class UserInterface
    {
        /// <summary>
        /// Declaring a droid collection item to reference the droid collection list
        /// as well as references to all the types of droids
        /// </summary>
        private DroidCollection droidCollection = new DroidCollection();
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
        private int numberShips;
        /// <summary>
        /// Method for creating a menu to select from the available options for interacting with
        /// the program.
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
        /// Method to add a droid to the droid collection.
        /// First prompts the user for a droid designation, then has them
        /// select the options that apply to the Droid abstract class and add
        /// those options to the base cost of the Droid.
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
        /// <summary>
        /// Method for the adding of a protocol droid.
        /// Prompts user to select number of languages, uses that to calculate the total cost
        /// of the protocol droid, then passes that into the droid collection for storage.
        /// </summary>
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
            protocol.mBaseCost = baseCost;
            protocol.NumberLanguages = numberLanguages;
            totalCost = protocol.CalculateTotalCost();
            droidCollection.AddProtocolDroid(name, model, color, material, baseCost, totalCost, numberLanguages);
        }
        /// <summary>
        /// Menu option for adding a utility droid.
        /// Will first prompt for the options which apply to the Utility
        /// Droid abstract class then prompt to choose a specification of utility droid.
        /// </summary>
        private void AddUtilityDroid()
        {
            Console.WriteLine("Does the droid have a toolbox? Y or N");
            string toolboxChoice = Console.ReadLine();
            switch (toolboxChoice)
            {
                case "Y":
                    toolbox = true;
                    break;
                case "y":
                    toolbox = true;
                    break;
                case "N":
                    toolbox = false;
                    break;
                case "n":
                    toolbox = false;
                    break;
                default:
                    Console.WriteLine("Error: You must choose a valid option.");
                    AddUtilityDroid();
                    break;
            }
            Console.WriteLine("Does the droid have a computer connection? Y or N");
            string computerChoice = Console.ReadLine();
            switch (computerChoice)
            {
                case "Y":
                    computerConnection = true;
                    break;
                case "y":
                    computerConnection = true;
                    break;
                case "N":
                    computerConnection = false;
                    break;
                case "n":
                    computerConnection = false;
                    break;
                default:
                    Console.WriteLine("Error: You must choose a valid option.");
                    AddUtilityDroid();
                    break;
            }
            Console.WriteLine("Does the droid have an arm? Y or N");
            string armChoice = Console.ReadLine();
            switch (armChoice)
            {
                case "Y":
                    arm = true;
                    break;
                case "y":
                    arm = true;
                    break;
                case "N":
                    arm = false;
                    break;
                case "n":
                    arm = false;
                    break;
                default:
                    Console.WriteLine("Error: You must choose a valid option.");
                    AddUtilityDroid();
                    break;
            }
            Console.WriteLine("Please choose the model of Utility Droid:");
            Console.WriteLine("1. Janitor");
            Console.WriteLine("2. Astromech");
            string modelChoice = Console.ReadLine();
            switch (modelChoice)
            {
                case "1":
                    model = "Janitor";
                    baseCost += 200m;
                    AddJanitorDroid();
                    break;
                case "2":
                    model = "Astromech";
                    baseCost += 500m;
                    AddAstromechDroid();
                    break;
            }
        }
        /// <summary>
        /// Method which will prompt the user for Astromech droid options, calculate the
        /// total cost of the finished droid, then add the droid to the Droid Collection
        /// for storage.
        /// </summary>
        private void AddAstromechDroid()
        {
            astromech = new Astromech();
            Console.WriteLine("Does the droid have a fire extinguisher? Y or N");
            string fireExtinguisherChoice = Console.ReadLine();
            switch (fireExtinguisherChoice)
            {
                case "Y":
                    fireExtinguisher = true;
                    break;
                case "y":
                    fireExtinguisher = true;
                    break;
                case "N":
                    fireExtinguisher = false;
                    break;
                case "n":
                    fireExtinguisher = false;
                    break;
                default:
                    Console.WriteLine("Error: You must choose a valid option.");
                    AddAstromechDroid();
                    break;
            }
            Console.WriteLine("Please choose the number of ship models the droid can service");
            Console.WriteLine("1. 10 models (Civilian Edition)");
            Console.WriteLine("2. 50 models (Military Edition)");
            string shipChoice = Console.ReadLine();
            switch (shipChoice)
            {
                case "1":
                    numberShips = 10;
                    astromech.NumberShips = 10;
                    break;
                case "2":
                    numberShips = 50;
                    astromech.NumberShips = 50;
                    break;
                default:
                    Console.WriteLine("Error: You must select from available options.");
                    AddAstromechDroid();
                    break;
            }
            astromech.mBaseCost = baseCost;
            astromech.FireExtinguisher = fireExtinguisher;
            astromech.Arm = arm;
            astromech.ComputerConnection = computerConnection;
            astromech.ToolBox = toolbox;            
            totalCost = astromech.CalculateTotalCost();
            droidCollection.AddAstromechDroid(name, model, color, material, baseCost, 
                totalCost, toolbox, computerConnection, arm, fireExtinguisher, numberShips);
        }
        /// <summary>
        /// Method for adding a Janitor droid.  Will prompt the user for options which apply to
        /// the Janitor droid class, calculate the cost of the finished droid, then pass the droid
        /// to the droid collection for storage.
        /// </summary>
        private void AddJanitorDroid()
        {
            janitor = new Janitor();
            Console.WriteLine("Does the droid have a trash compactor? Y or N");
            string trashCompactorChoice = Console.ReadLine();
            switch (trashCompactorChoice)
            {
                case "Y":
                    trashCompactor = true;
                    break;
                case "y":
                    trashCompactor = true;
                    break;
                case "N":
                    trashCompactor = false;
                    break;
                case "n":
                    trashCompactor = false;
                    break;
                default:
                    Console.WriteLine("Error: You must choose a valid option.");
                    AddJanitorDroid();
                    break;
            }
            Console.WriteLine("Does the droid have a vacuum? Y or N");
            string vacuumChoice = Console.ReadLine();
            switch (vacuumChoice)
            {
                case "Y":
                    vacuum = true;
                    break;
                case "y":
                    vacuum = true;
                    break;
                case "N":
                    vacuum = false;
                    break;
                case "n":
                    vacuum = false;
                    break;
                default:
                    Console.WriteLine("Error: You must choose a valid option.");
                    AddJanitorDroid();
                    break;
            }
            janitor.mBaseCost = baseCost;
            janitor.TrashCompactor = trashCompactor;
            janitor.Vacuum = vacuum;
            janitor.ComputerConnection = computerConnection;
            janitor.ToolBox = toolbox;
            janitor.Arm = arm;
            totalCost = janitor.CalculateTotalCost();
            droidCollection.AddJanitorDroid(name, model, color, material, baseCost,
                totalCost, toolbox, computerConnection, arm, trashCompactor, vacuum);
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
