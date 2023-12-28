using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    /// <summary>
    /// This class represents tasks on a ToDo list: once completed, they do not recur and can be deleted
    /// </summary>
    public class ToDo
    {
        public bool completed;
        public string name;
        public ToDo(string name)
        {
            this.name = name;
        }
    }
}
