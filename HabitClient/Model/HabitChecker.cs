using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal static class HabitChecker
    {
        public static HabitModel? model;        //which model the created habits will be populated in
        /// <summary>
        /// This function does all the checking fo
        /// </summary>
        /// <param name="s"></param>
        public static void CreateHabit(Specifications s)
        {
            HabitSpecs hs = (HabitSpecs)s;                      //treat parameter has a habitSpecs
            if (hs.name.Length == 0 || hs.name.Length > 25)         //if no text provided or too long,
            {
                hs.error = true;                                //set error to true
                lock(model)
                    model!.Habits.Add(new Habit(hs));               //add to Habits
            }
                
            if (!hs.positive && !hs.negative)                   //habit must be good/bad or both, not neither
            {
                hs.error = true;                                //set error to true
                lock(model)
                    model!.Habits.Add(new Habit(hs));               //add to habits
            }
            model!.Habits.Add(new Habit(hs));
            //create a habit, store it in Model, then send an event to view to update xaml
        }
    }
}
