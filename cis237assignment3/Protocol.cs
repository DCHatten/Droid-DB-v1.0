using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// David Hatten
/// Protocol class extends the Droid class, and contains methods that are specific to the protocol droid type.
/// </summary>
namespace cis237assignment3
{
    class Protocol : Droid
    {
        //Backing Fields
        private int mNumberLanguages;
        private const decimal mCostPerLanguage = 500m;
        //Getters and Setters
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
        /// <summary>
        /// ToString method which will override the droid method, returning the information from the droid class
        /// as well as the protocol droids number of languages and total cost
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "\tNumber of Languages: " + mNumberLanguages.ToString() + " million" + Environment.NewLine + 
                "\tTotal Cost: " + mTotalCost.ToString("n2") + " credits";
        }
        /// <summary>
        /// Method for calculating the total cost, based on the base cost for the options selected in the droid class plus
        /// the number of languages spoken
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateTotalCost()
        {
            mTotalCost = mBaseCost + (mNumberLanguages * mCostPerLanguage);
            return mTotalCost;
        }
    }
}
