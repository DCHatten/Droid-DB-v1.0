using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection : IDroidCollection
    {
        public List<Droid> droidList;

        public void AddProtocolDroid() { }
        public void AddJanitorDroid() { }
        public void AddAstromechDroid() { }
    }
}
