using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Model
{
    /// <summary>
    /// This class is for use by the View, it holds the data from the user, but without any processing
    /// this just enforces that view should not be doing any hard computation
    /// </summary>
    public class HabitSpecs : Specifications
    {
        public bool positive;
        public bool negative;
        public HabitSpecs(string name, bool error, bool positive, bool negative) : base(name, error)
        {
            this.positive = positive;
            this.negative = negative;
        }
    }
}
