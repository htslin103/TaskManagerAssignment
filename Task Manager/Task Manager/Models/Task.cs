using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace TaskManager.Models
{
    public class Task: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!EqualityComparer<T>.Default.Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }
            return false;

        }

        //Data
        private string _date;
        private string _name;
        private int _id; 

        //Gets or sets values
        //Task Date
        public string Date
        {
            get => _date;
            set => SetProperty(ref _date, value);
        }

        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }
        //Task Name
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        //Default constructor
        public Task()
        {
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
