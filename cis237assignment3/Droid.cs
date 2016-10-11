using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {
        /// <summary>
        /// Backing fields for basic information on the droid
        /// </summary>
        protected string mMaterial;
        protected string mModel;
        protected string mColor;
        /// <summary>
        /// Backing field for the different costs of a droid
        /// </summary>
        protected decimal mBaseCost = 500m;
        protected decimal mTotalCost;
        /// <summary>
        /// Property for the Total Cost of a droid
        /// </summary>
        public abstract decimal TotalCost { get; set; }
        /// <summary>
        /// Constructor that takes basic information which will apply to all droids, regardless of type
        /// </summary>
        /// <param name="model"></param>
        /// <param name="color"></param>
        /// <param name="material"></param>
        public Droid(string model, string color, string material)
        {
            mModel = model;
            mMaterial = material;
            mModel = model;
        }
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Droid() { }
        /// <summary>
        /// Overriding the ToString method to return the backing fields for the Droid class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Model: " + mModel + Environment.NewLine + 
                "\t\tMaterial: " + mMaterial + Environment.NewLine + 
                "\t\tColor: " + mColor + Environment.NewLine + 
                "\t\tBase Cost: " + mBaseCost.ToString("n2") + " credits";
        }
        /// <summary>
        /// Method for calculating the total cost of a droid, based on the options selected
        /// </summary>
        public abstract decimal CalculateTotalCost();
    }
}
