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
        public bool error;

        public bool positive;
        public bool negative;
        public string name;
        public Habit(string name, bool positive, bool negative)
        {
            this.name = name;

            this.positive = positive;
            this.negative = negative;
            this.error=false;

        }
        /// <summary>
        /// Copies in data from a HabitSpecs object. HabitChecker class has functions for checking validity
        /// </summary>
        /// <param name="s"></param>
        public Habit(HabitSpecs s)
        {
            this.name=s.name;
            this.positive = s.positive;
            this.negative = s.negative;
            this.error = s.error;

        }
    }
}
