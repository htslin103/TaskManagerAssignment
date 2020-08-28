using System;
using System.Diagnostics;
using System.Windows.Input;
using TaskManager.Models;
using System.ComponentModel;
using Task_Manager.Models;
using System.Collections.Generic;
//using TaskManager.Commands;

namespace TaskManager.ViewModels
{
  
    public class TaskViewModel: INotifyPropertyChanged
    {  /// <summary>
       /// Initializes a new instance of the CustomerViewModel class 
       /// </summary>

        public event PropertyChangedEventHandler PropertyChanged;
        TaskService ObjTaskService;

        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private List<Task> taskList = new List<Task>();
        public List<Task> TasksList
        {
            get { return taskList; }
            set { taskList = value; OnPropertyChanged("TasksList"); }
        }

        private void LoadData()
        {
            TasksList = ObjTaskService.GetAll();
        }

        public TaskViewModel() {

            ObjTaskService = new TaskService();
            LoadData();
        }

      

        public ICommand UpdateCommand
        {
            get;
            private set;
        }
        //Saves task edits
        public void SaveChanges()
        {
            Debug.Assert(false, String.Format("{0} was updated.", Task.Name));
        }
    } 
}
