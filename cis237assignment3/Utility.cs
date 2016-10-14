using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Utility : Droid
    {
        //Backing Fields
        protected bool mToolbox;
        protected bool mComputerConnection;
        protected bool mArm;
        //Abstract getters and setters that the Astromech and Janitor classes will define and implement
        public abstract bool ToolBox { get; set; }
        public abstract bool ComputerConnection { get; set; }
        public abstract bool Arm { get; set; }
        public override decimal TotalCost { get; set; }
        /// <summary>
        /// Constructor which will take all info for the utility class, passing what it can to the droid class
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
        public Utility(string name, string model, string color, string material, decimal baseCost, decimal totalCost, bool toolbox, bool computerConnection, bool arm)
            : base(name, model, color, material, baseCost, totalCost)
        {
            mToolbox = toolbox;
            mComputerConnection = computerConnection;
            mArm = arm;
        }
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Utility() : base() { }
        /// <summary>
        /// Method for calculating the total cost based on base cost of the model plus the options selected
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateTotalCost()
        {
            decimal mOptionCost = 0m;
            if (mToolbox)
            {
                mOptionCost += 50m;
            }
            if (mComputerConnection)
            {
                mOptionCost += 200m;
            }
            if (mArm)
            {
                mOptionCost += 100m;
            }
            mTotalCost = mBaseCost + mOptionCost;
            return mTotalCost;
        }
        /// <summary>
        /// To String method which will concat all info for the utility class to the droid class for printing to screen
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "\tToolbox: " + mToolbox.ToString() + Environment.NewLine +
                "\tComputer Connection: " + mComputerConnection.ToString() + Environment.NewLine + 
                "\tArm: " + mArm.ToString();
        }
    }
}
