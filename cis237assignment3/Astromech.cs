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

        public Astromech(string name, string model, string color, string material, decimal baseCost, decimal totalCost,
            bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
            : base(name, model, color, material, baseCost, totalCost, toolbox, computerConnection, arm)
        {
            mFireExtinguisher = fireExtinguisher;
            mNumberShips = numberShips;
        }
        public Astromech() : base() { }

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

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + 
                "\tFire Extinguisher: " + mFireExtinguisher.ToString() + Environment.NewLine +
                "\tNumber of Ships: " + mNumberShips.ToString() + Environment.NewLine + 
                "\tTotal Cost: " + mTotalCost.ToString("n2") + " credits";
        }
    }
}
