using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        private bool mTrashCompactor;
        private bool mVacuum;

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

        public Janitor(string name, string model, string color, string material, decimal baseCost, 
            decimal totalCost, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
            : base(name, model, color, material, baseCost, totalCost, toolbox, computerConnection, arm)
        {
            mTrashCompactor = trashCompactor;
            mVacuum = vacuum;
        }
        public Janitor() : base() { }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "\tTrash Compactor: " + mTrashCompactor.ToString() + Environment.NewLine + 
                "\tVacuum: " + mVacuum.ToString() + Environment.NewLine + "\tTotal Cost: " + mTotalCost.ToString("n2") + " credits";
        }

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
