using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// this is the superclass from which all data capture holder classes created by the view are derived.
    /// they don't have much in common, but need to be related so they can be stored together in data structures
    /// </summary>
    abstract public class Specifications
    {
        public string name;
        public bool error;
        protected Specifications(string name, bool error)
        {
            this.name = name;
            this.error = error;
        }
    }
}
