using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// David Hatten
/// Janitor class which inherits from Utility and subsequently the Droid class.
/// Has various methods specific to the janitor droid type.
/// </summary>
namespace cis237assignment3
{
    class Janitor : Utility
    {
        //Backing Fields
        private bool mTrashCompactor;
        private bool mVacuum;
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
        public bool TrashCompactor
        {
            get { return mTrashCompactor; }
            set { mTrashCompactor = value; }
        }
        public bool Vacuum
        {
            get { return mVacuum; }
            set { mVacuum = value; }
        }
        /// <summary>
        /// Constructor which will take all data for the janitor class, passing what it can to the
        /// utility class, and subsequently the droid class.
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
        /// <param name="trashCompactor"></param>
        /// <param name="vacuum"></param>
        public Janitor(string name, string model, string color, string material, decimal baseCost, 
            decimal totalCost, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
            : base(name, model, color, material, baseCost, totalCost, toolbox, computerConnection, arm)
        {
            mTrashCompactor = trashCompactor;
            mVacuum = vacuum;
        }
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Janitor() : base() { }
        /// <summary>
        /// To String method which will concat all janitor droid info on the end of the droid and utility class info
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "\tTrash Compactor: " + mTrashCompactor.ToString() + Environment.NewLine + 
                "\tVacuum: " + mVacuum.ToString() + Environment.NewLine + "\tTotal Cost: " + mTotalCost.ToString("n2") + " credits";
        }
        /// <summary>
        /// Method for calculating the total cost of the janitor droid based on the base cost of the unit plus selected options
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateTotalCost()
        {
            decimal optionCost = 0m;
            if (mToolbox)
            {
                optionCost += 50m;
            }
            if (mComputerConnection)
            {
                optionCost += 200m;
            }
            if (mArm)
            {
                optionCost += 100m;
            }
            if (mTrashCompactor)
            {
                optionCost += 100m;
            }
            if (mVacuum)
            {
                optionCost += 50m;
            }
            mTotalCost = mBaseCost + optionCost;
            return mTotalCost;
        }
    }
}
