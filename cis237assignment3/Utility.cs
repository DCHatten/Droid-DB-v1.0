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

        public override decimal TotalCost { get; set; }
        public override abstract decimal CalculateTotalCost();
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "\t\tToolbox: " + mToolbox.ToString() + Environment.NewLine +
                "\t\tComputer Connection: " + mComputerConnection.ToString() + Environment.NewLine + 
                "\t\tArm: " + mArm.ToString();
        }
        public Utility(string model, string color, string material, bool toolbox, bool computerConnection, bool arm)
            : base(model, color, material)
        {
            mToolbox = toolbox;
            mComputerConnection = computerConnection;
            mArm = arm;
        }
    }
}
