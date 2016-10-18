using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// David Hatten
/// DroidCollection class, defines the list variable where all created droid data will be stored.
/// Also has methods for adding droids to the collection using the constructors of the other classes.
/// </summary>
namespace cis237assignment3
{
    class DroidCollection
    {
        //Backing Fields
        public List<Droid> droidList = new List<Droid>();
        private Protocol protocolDroid;
        private Janitor janitorDroid;
        private Astromech astromechDroid;
        /// <summary>
        /// Method for creating a new protocol droid using the protocol droid constructor, then storing that droid in the droid colection
        /// </summary>
        /// <param name="name"></param>
        /// <param name="model"></param>
        /// <param name="color"></param>
        /// <param name="material"></param>
        /// <param name="baseCost"></param>
        /// <param name="totalCost"></param>
        /// <param name="numberLanguages"></param>
        public void AddProtocolDroid(string name, string model, string color, string material, decimal baseCost, decimal totalCost, int numberLanguages)
        {
            protocolDroid = new Protocol(name, model, color, material, baseCost, totalCost, numberLanguages);
            droidList.Add(protocolDroid);
        }
        /// <summary>
        /// Method for creating a new janitor droid using the janitor constructor then storing that in the droid collection.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="model"></param>
        /// <param name="color"></param>
        /// <param name="material"></param>
        /// <param name="baseCost"></param>
        /// <param name="totalCost"></param>
        /// <param name="toolbox"></param>
        /// <param name="computerConnection"></param>
        /// <param name="arm"></param>
        /// <param name="trashCompactor"></param>
        /// <param name="vacuum"></param>
        public void AddJanitorDroid(string name, string model, string color, string material, decimal baseCost, decimal totalCost, bool toolbox, 
            bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
        {
            janitorDroid = new Janitor(name, model, color, material, baseCost, totalCost, toolbox, computerConnection, arm, trashCompactor, vacuum);
            droidList.Add(janitorDroid);
        }
        /// <summary>
        /// Method for creating a new astromech droid using the astromech constructor then storing that in the droid collection
        /// </summary>
        /// <param name="name"></param>
        /// <param name="model"></param>
        /// <param name="color"></param>
        /// <param name="material"></param>
        /// <param name="baseCost"></param>
        /// <param name="totalCost"></param>
        /// <param name="toolbox"></param>
        /// <param name="computerConnection"></param>
        /// <param name="arm"></param>
        /// <param name="fireExtinguisher"></param>
        /// <param name="numberShips"></param>
        public void AddAstromechDroid(string name, string model, string color, string material, decimal baseCost, decimal totalCost, bool toolbox,
            bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
        {
            astromechDroid = new Astromech(name, model, color, material, baseCost, totalCost, toolbox, computerConnection, arm, fireExtinguisher, numberShips);
            droidList.Add(astromechDroid);
        }
    }
}
