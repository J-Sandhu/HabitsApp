using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HabitModel
    {
        public delegate void ModelTask(Specifications s);      //the type of tasks that populate the TaskQueue
        public HashSet<Daily> dailies;
        public HashSet<ToDo> ToDos;
        public HashSet<Habit> Habits;
        Queue<Tuple<ModelTask, Specifications>> TaskQueue;
        public HabitModel()
        {
            dailies = new HashSet<Daily>();             //create dictionaries to hold all the data
            ToDos = new HashSet<ToDo>();
            Habits = new HashSet<Habit>();
            TaskQueue = new();                          //create a queue for tasks that need to be performed

            HabitChecker.model = this;
        }
        /// <summary>
        /// Gets whatever task has been queued up and performs it.
        /// </summary>
        /// <returns></returns>
        public bool Work()
        {
            lock(TaskQueue)
            {
                if (TaskQueue.Count>0)
                {
                    var TaskTuple =TaskQueue.Dequeue();
                    TaskTuple.Item1(TaskTuple.Item2);
                    return true;
                }    
            }
            return false;
        }

        public void AddWork(Specifications s)
        {
            if (s is HabitSpecs)
            {
                TaskQueue.Enqueue(new Tuple<ModelTask, Specifications>(new ModelTask(HabitChecker.CreateHabit), s));
            }
        }

    }
}
