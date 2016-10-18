using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// David Hatten
/// IDroid interface which defines a couple of methods which all droid types will use
/// </summary>
namespace cis237assignment3
{
    interface IDroid
    {
        /// <summary>
        /// Defining the Calculate Total Cost method that all classes that implement this interface will use
        /// </summary>
        /// <returns></returns>
        decimal CalculateTotalCost();
        /// <summary>
        /// Defining a getter and setter for the total cost determined in the previous method
        /// </summary>
        decimal TotalCost { get; set; }
    }
}
