using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {
        private bool mFireExtinguisher;
        private int mNumberShips;

        public Astromech(string model, string color, string material, bool toolbox, 
            bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
            : base(model, color, material, toolbox, computerConnection, arm)
        {
            mFireExtinguisher = fireExtinguisher;
            mNumberShips = numberShips;
        }
        public override decimal TotalCost
        {
            get { return mTotalCost; }
            set { mTotalCost = value; }
        }

        public override decimal CalculateTotalCost()
        {
            decimal optionCost = 0m;
            if (mToolbox == true)
            {
                optionCost = optionCost + 50m;
            }
            if (mComputerConnection == true)
            {
                optionCost = optionCost + 200m;
            }
            if (mArm == true)
            {
                optionCost = optionCost + 100m;
            }
            if (mFireExtinguisher == true)
            {
                optionCost = optionCost + 50m;
            }
        
            mTotalCost = mBaseCost + optionCost;
            return mTotalCost;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + 
                "\t\tFire Extinguisher: " + mFireExtinguisher.ToString() + Environment.NewLine +
                "\t\tNumber of Ships: " + mNumberShips.ToString() + Environment.NewLine + 
                "\t\tTotal Cost: " + mTotalCost.ToString("n2") + " credits";
        }
    }
}
