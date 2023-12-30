using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// This class contains sided habits: Habits that aren't scheduled, and are positive, negative or possibly both
    /// Eg: "maintained/forsaken diet"
    /// </summary>
    public class Habit
    {
        public bool positive;
        public bool negative;
        public string name;
        public Habit(string name, bool positive, bool negative)
        {
            this.name = name;

            this.positive = positive;
            this.negative = negative;

        }
    }
}
