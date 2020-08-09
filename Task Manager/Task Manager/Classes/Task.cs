using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TaskManager
{
    public class Task
    {
      
        public string Date
        {
            get; set;
        }  

        public string Name
        {
            get;
            set;
        }

        public bool isComplete
        {
            get; set;
        }

        public bool isOverdue
        {
            get; set;
        }

        public Task(string date, string name)
        {
            Date = date;
            Name = name;
        }

        public Task()
        {
        }

        public bool taskIsComplete(Task task)
        {
            if (task.isComplete == true)
            {
                return true;
            }

            return false;
        }

        public bool taskIsOverdue(Task task)
        {
            if (task.isOverdue == true)
            {
                return true;
            }

            return false;
        }


    }
}
