using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// David Hatten
/// Astromech classes inherits from Utility and, subsequently, Droid classes.
/// Also contains methods that are unique to the Astromech droid type.
/// </summary>
namespace cis237assignment3
{
    class Astromech : Utility
    {
        //Backing Fields
        private bool mFireExtinguisher;
        private int mNumberShips;
        //Getters and Setters
        public override decimal TotalCost
        {
            get { return mTotalCost; }
            set { mTotalCost = value; }
        }
        public override bool ToolBox
        {
            get { return mToolbox; }
            set { mToolbox = value; }
        }
        public override bool ComputerConnection
        {
            get { return mComputerConnection; }
            set { mComputerConnection = value; }
        }
        public override bool Arm
        {
            get { return mArm; }
            set { mArm = value; }
        }
        public bool FireExtinguisher
        {
            get { return mFireExtinguisher; }
            set { mFireExtinguisher = value; }
        }
        public int NumberShips
        {
            get { return mNumberShips; }
            set { mNumberShips = value; }
        }
        /// <summary>
        /// Constructor which will pass all properties of the astromech class to first the utility class and then the droid 
        /// class to create an astromech of type utility droid
        /// </summary>
        /// <param name="name"></param>
        /// <param name="model"></param>
        /// <param name="color"></param>
        /// <param name="material"></param>
        /// <param name="baseCost"></param>
        /// <param name="totalCost"></param>
        /// <param name="toolbox"></param>
        /// <param name="computerConnection"></param>
        /// <param name="arm"></param>
        /// <param name="fireExtinguisher"></param>
        /// <param name="numberShips"></param>
        public Astromech(string name, string model, string color, string material, decimal baseCost, decimal totalCost,
            bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
            : base(name, model, color, material, baseCost, totalCost, toolbox, computerConnection, arm)
        {
            mFireExtinguisher = fireExtinguisher;
            mNumberShips = numberShips;
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public Astromech() : base() { }
        /// <summary>
        /// Method for calculating total cost based on base cost of the model plus options selected
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateTotalCost()
        {
            decimal optionCost = 0m;
            if (mToolbox)
            {
                optionCost = optionCost + 50m;
            }
            if (mComputerConnection)
            {
                optionCost = optionCost + 200m;
            }
            if (mArm)
            {
                optionCost = optionCost + 100m;
            }
            if (mFireExtinguisher)
            {
                optionCost = optionCost + 50m;
            }
        
            mTotalCost = mBaseCost + optionCost + (mNumberShips * 50m);
            return mTotalCost;
        }
        /// <summary>
        /// To String method which will concat all info from the droid to string and the utility to string with the
        /// astromech info for printing to the screen.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + 
                "\tFire Extinguisher: " + mFireExtinguisher.ToString() + Environment.NewLine +
                "\tNumber of Ships: " + mNumberShips.ToString() + " ships" + Environment.NewLine + 
                "\tTotal Cost: " + mTotalCost.ToString("n2") + " credits";
        }
    }
}
