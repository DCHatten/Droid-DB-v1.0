using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Utility : Droid
    {
        protected bool mToolbox;
        protected bool mComputerConnection;
        protected bool mArm;

        public abstract bool ToolBox { get; set; }
        public abstract bool ComputerConnection { get; set; }
        public abstract bool Arm { get; set; }
        public override decimal TotalCost { get; set; }

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
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "\tToolbox: " + mToolbox.ToString() + Environment.NewLine +
                "\tComputer Connection: " + mComputerConnection.ToString() + Environment.NewLine + 
                "\tArm: " + mArm.ToString();
        }
        public Utility(string name, string model, string color, string material, decimal baseCost, decimal totalCost, bool toolbox, bool computerConnection, bool arm)
            : base(name, model, color, material, baseCost, totalCost)
        {
            mToolbox = toolbox;
            mComputerConnection = computerConnection;
            mArm = arm;
        }
        public Utility() : base() { }
    }
}
