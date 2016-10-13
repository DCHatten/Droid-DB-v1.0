using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection
    {
        public List<Droid> droidList = new List<Droid>();
        private Protocol protocolDroid;
        private Janitor janitorDroid;
        private Astromech astromechDroid;

        public void AddProtocolDroid(string name, string model, string color, string material, decimal baseCost, decimal totalCost, int numberLanguages)
        {
            protocolDroid = new Protocol(name, model, color, material, baseCost, totalCost, numberLanguages);
            droidList.Add(protocolDroid);
        }
        public void AddJanitorDroid(string name, string model, string color, string material, decimal baseCost, decimal totalCost, bool toolbox, 
            bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
        {
            janitorDroid = new Janitor(name, model, color, material, baseCost, totalCost, toolbox, computerConnection, arm, trashCompactor, vacuum);
            droidList.Add(janitorDroid);
        }
        public void AddAstromechDroid(string name, string model, string color, string material, decimal baseCost, decimal totalCost, bool toolbox,
            bool computerConnection, bool arm, bool fireExtinguisher, int numberShips)
        {
            astromechDroid = new Astromech(name, model, color, material, baseCost, totalCost, toolbox, computerConnection, arm, fireExtinguisher, numberShips);
            droidList.Add(astromechDroid);
        }
    }
}
