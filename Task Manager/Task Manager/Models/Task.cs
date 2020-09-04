using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace TaskManager.Models
{
    public class Task
    {

        //Data
        public string Date { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public bool isComplete { get; set; }
        public bool isOverdue { get; set; }

        //Default constructor
        public Task(){ }

        public Task(string name)
        {
            Name = name;
        }

        public Task(string date, string name)
        {
            Date = date;
            Name = name;
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
