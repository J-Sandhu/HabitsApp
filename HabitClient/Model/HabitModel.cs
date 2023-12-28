using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HabitModel
    {
        public HashSet<Daily> dailies;
        public HashSet<ToDo> ToDos;
        public HashSet<Habit> Habits;
        public HabitModel()
        {
            dailies = new HashSet<Daily>();
            ToDos = new HashSet<ToDo>();
            Habits = new HashSet<Habit>();

        }
    }
}
