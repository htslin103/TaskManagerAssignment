using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace TaskManager.Models
{
    public class Task
    {

        //Data
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public bool IsComplete { get; set; }
        public bool IsOverdue { get; set; }

        //Default constructor
        public Task(){ }

        public Task(string name)
        {
            Name = name;
        }

        public Task(DateTime date, string name)
        {
            Date = date;
            Name = name;
        }

        public bool taskIsComplete(Task task)
        {
            if (task.IsComplete == true)
            {
                return true;
            }

            return false;
        }

        public bool taskIsOverdue(Task task)
        {
            if (task.IsOverdue == true)
            {
                return true;
            }

            return false;
        }


    }
}
