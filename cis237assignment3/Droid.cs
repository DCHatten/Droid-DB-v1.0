using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {
        protected decimal mTotalCost;
        public decimal TotalCost
        {
            get
            {
                return mTotalCost;
            }

            set
            {
                mTotalCost = value;
            }
        }

        public void CalculateTotalCost()
        {
            throw new NotImplementedException();
        }
    }
}
