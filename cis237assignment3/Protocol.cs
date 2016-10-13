using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        private int mNumberLanguages;
        private const decimal mCostPerLanguage = 500m;

        public override decimal TotalCost
        {
            get { return mTotalCost; }
            set { mTotalCost = value; }
        }
        public int NumberLanguages
        {
            get { return mNumberLanguages; }
            set { mNumberLanguages = value; }
        }
        /// <summary>
        /// Constructor which uses the parent constructor and adds the number of languages, specific to the protocol droid
        /// </summary>
        /// <param name="model"></param>
        /// <param name="color"></param>
        /// <param name="material"></param>
        /// <param name="numberLanguages"></param>
        public Protocol(string name, string model, string color, string material, decimal baseCost, decimal totalCost, int numberLanguages)
            : base(name, model, color, material, baseCost, totalCost)
        {
            mNumberLanguages = numberLanguages;
        }
        /// <summary>
        /// Default constructor of Protocol
        /// </summary>
        public Protocol() : base() { }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "\tNumber of Languages: " + mNumberLanguages.ToString() + Environment.NewLine + 
                "\tTotal Cost: " + mTotalCost.ToString("n2") + " credits";
        }
        public override decimal CalculateTotalCost()
        {
            mTotalCost = mBaseCost + (mNumberLanguages * mCostPerLanguage);
            return mTotalCost;
        }
    }
}
