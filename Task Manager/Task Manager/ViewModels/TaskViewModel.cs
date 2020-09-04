using System;
using TaskManager.Models;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Generic;
using ReactiveUI;
using Splat;
using System.Windows;
using System.Reactive;

namespace TaskManager.ViewModels
{

    public class TaskViewModel : ReactiveObject
    { 
        private ObservableCollection<Task> taskList;
        private Task selectedTask;
        private string contentName;
        private string contentDate;
 


        public ReactiveCommand<string, Unit> AddCommand { get; }
        public ReactiveCommand<Task, Unit> DeleteCommand { get; }

        //Constructor
        public TaskViewModel()
        {

         
            // create a task list with fake     
            taskList = new ObservableCollection<Task>()
            {
                new Task { Id=1, Date = "01/10/2020" , Name = "Fight stuff"},
                new Task { Id=2, Date = "02/10/2020" , Name = "Cook stuff"},
                new Task { Id=3, Date = "03/10/2020" , Name = "Destroy stuff"}
            };
            //load the data
            LoadData();
            AddCommand = ReactiveCommand.Create<string>(x => AddNewTask(x));
            DeleteCommand = ReactiveCommand.Create<Task>(x => DeleteTask(SelectedTask));
        }

        public Task SelectedTask
        {
            get { return selectedTask; }
            set => this.RaiseAndSetIfChanged(ref selectedTask, value);
        }
        // content for new task getter and setter
        public string ContentName
        {
            get { return contentName; }
            set => this.RaiseAndSetIfChanged(ref contentName, value);
        }

        public string ContentDate
        {
            get { return contentDate; }
            set => this.RaiseAndSetIfChanged(ref contentDate, value);
        }

        public DateTime CurrentDate
        {
            get
            {
                return DateTime.Now;
            }
        }

        //Loads the task list to read
        public ObservableCollection<Task> LoadData()
        {
            return taskList;
        }

        public ObservableCollection<Task> TaskList
        {
            get { return taskList; }
            set => this.RaiseAndSetIfChanged(ref taskList, value);       
        }

        //Adds a new task to the list 
        public void AddNewTask(string contentNew)
        {
            if (string.IsNullOrWhiteSpace(ContentName))//ContentNew
            {
                // display error message
                MessageBox.Show("Please enter a name for the new task", "Error");
                return;
            }
            if (string.IsNullOrWhiteSpace(ContentDate))//ContentNew
            {
                // display error message
                MessageBox.Show("Please enter a date for the new task", "Error");
                return;
            }

            // create new task object
            var newTask = new Task { Name = ContentName, Date = ContentDate };
            // assign id to new task
            if (taskList.Count != 0) // list is not empty, current id = last id + 1
            {
                newTask.Id = taskList.Max(x => x.Id) + 1;
            }
            else // if list is empty start with id = 1
            {
                newTask.Id = 1;
            }

            // add to list
            taskList.Add(newTask);
            //Load the list again
            LoadData();
        }

        /// <summary>
        /// Deletes task from the list
        /// </summary>
        /// <param name="task">Task object to be deleted</param>
        public void DeleteTask(Task task)
        {
            if (task != null)
            {
                try
                {
                    // remove task from list
                    taskList.Remove(task);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error deleting task", "Error");
                }
                
            }

        }
    } 
}
