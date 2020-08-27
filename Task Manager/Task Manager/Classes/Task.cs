using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TaskManager
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

        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private string _date;
        private string _name;
        public string Date
        {
            get => _date;
            set => SetProperty(ref _date, value);
        }  

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
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
