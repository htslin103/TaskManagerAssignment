using System;
using TaskManager.Models;
using System.ComponentModel;
using System.Collections.ObjectModel;
using TaskManager.Commands;
using System.Linq;
using System.Collections.Generic;

namespace TaskManager.ViewModels
{

    public class TaskViewModel : INotifyPropertyChanged
    {  /// <summary>
       /// Initializes a new instance of the CustomerViewModel class 
       /// </summary>
       /// 
        public event PropertyChangedEventHandler PropertyChanged;
        TaskService ObjTaskService;

        public TaskViewModel()
        {

            ObjTaskService = new TaskService();
            LoadData();
            CurrentTask = new Task();
            saveCommand = new RelayCommand(Save);
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
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
            TasksList = new List<Task>(ObjTaskService.GetAll());
        }

       

        private Task currentTask;
        public Task CurrentTask {

            get { return currentTask; } 
            set { currentTask = value;  OnPropertyChanged("CurrentTask"); }
            }
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged("Message"); }
        }

        private RelayCommand saveCommand;
        public RelayCommand SaveCommand { 
            get { return saveCommand;  }        
        }
      
        public void Save()
        {

            try
            {
   
                var IsSaved = ObjTaskService.Add(CurrentTask);
                LoadData();
                if(IsSaved)
                {
                    Message = "Task saved";
                }
                else
                {
                    Message = "Task save operation failed";
                }
            }
            catch (Exception ex)
            {

                Message = ex.Message; 
            }

        }

        private RelayCommand updateCommand;
        public RelayCommand UpdateCommand
        {
            get { return updateCommand; }
        }

        public void Update()
        {
            try
            {
                var IsUpdate = ObjTaskService.Update(CurrentTask);
                if(IsUpdate)
                {
                    Message = "Task Updated";
                    LoadData();
                }
                else
                {
                    Message =  "Update operation failed";
                }

            }
            catch (Exception ex)
            {

                Message = ex.Message;
            }
        }

        private RelayCommand deleteCommand;
        public RelayCommand DeleteCommand
        {
            get { return deleteCommand; }
        }

        public void Delete()
        {
            try

            {
                var IsDelete = ObjTaskService.Delete(CurrentTask.Id);
                if(IsDelete)
                {
                    Message = "Task deleted";
                }
                else
                {
                    Message = "Delete operation failed";
                }
            }

            catch (Exception ex) 
            {

                Message = ex.Message;
            }
        }
    } 
}
