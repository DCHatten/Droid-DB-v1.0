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

        public Janitor(string model, string color, string material, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
            : base(model, color, material, toolbox, computerConnection, arm)
        {
            mTrashCompactor = trashCompactor;
            mVacuum = vacuum;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "\t\tTrash Compactor: " + mTrashCompactor.ToString() + Environment.NewLine + 
                "\t\tVacuum: " + mVacuum.ToString() + Environment.NewLine + "\t\tTotal Cost: " + mTotalCost.ToString("n2") + " credits";
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
            if (mTrashCompactor == true)
            {
                optionCost = optionCost + 100m;
            }
            if (mVacuum == true)
            {
                optionCost = optionCost + 50m;
            }
            mTotalCost = mBaseCost + optionCost;
            return mTotalCost;
        }

        public override decimal TotalCost
        {
            get { return mTotalCost; }
            set { mTotalCost = value; }
        }
    }
}
