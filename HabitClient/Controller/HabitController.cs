using Model;
using System.Xml.Schema;

namespace Controller
{

    public class HabitController
    {
        HabitModel model;           //holds all of the data and how it will be operated on

        //TODO: hold some kind of time tracker thing that can send out events

        /// <summary>
        /// default constructor
        /// </summary>
        public HabitController()
        {
            model = new();
        }

        /// <summary>
        /// calls the model's method for adding a habit, returns whether it was successful or not
        /// </summary>
        /// <returns></returns>
        public bool AddHabit()
        {
            return false;
        }
        /// <summary>
        /// calls the model's method for removing a habit, returns whether it was successful or not
        /// </summary>
        /// <returns></returns>
        public bool RemoveHabit() 
        {
            return false;
        }

        /// <summary>
        /// calls the model's method for adding a ToDo item, returns whether it was successful or not
        /// </summary>
        /// <returns></returns>
        public bool AddToDo()
        {
            return false;
        }
        /// <summary>
        /// calls the model's method for removing a ToDo item, returns whether it was successful or not
        /// </summary>
        /// <returns></returns>
        public bool RemoveToDo()
        {
            return false;
        }

        /// <summary>
        /// calls the model's method for adding a daily item, returns whether it was successful or not
        /// </summary>
        /// <returns></returns>
        public bool AddDaily()
        {
            return false;
        }
        /// <summary>
        /// calls the model's method for removing a daily item, returns whether it was successful or not
        /// </summary>
        /// <returns></returns>
        public bool RemoveDaily()
        {
            return false;
        }
    }


}