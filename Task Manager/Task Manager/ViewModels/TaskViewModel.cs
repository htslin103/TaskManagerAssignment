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
using System.Windows.Forms;

namespace TaskManager.ViewModels
{

    public class TaskViewModel : ReactiveObject
    { 
        private ObservableCollection<Task> taskList;
        private Task selectedTask;
        private string contentName;
        private DateTime contentDate;
        private bool isOverdue;
        private bool isComplete;
 


        public ReactiveCommand<string, Unit> AddCommand { get; }
        public ReactiveCommand<Task, Unit> DeleteCommand { get; }
        public ReactiveCommand<Task, Unit> CompleteCommand { get; }

        //Constructor
        public TaskViewModel()
        {

         
            // create a task list with fake     
            taskList = new ObservableCollection<Task>()
            {
                new Task { Id=1, Date = new DateTime(2020, 1, 18) , Name = "Fight stuff", IsOverdue = true},
                new Task { Id=2, Date = new DateTime(2020, 2, 7) , Name = "Cook stuff", IsOverdue = true},
                new Task { Id=3, Date = new DateTime(2020, 3, 5) , Name = "Destroy stuff", IsOverdue =true}
            };
            //load the data
            LoadData();
            AddCommand = ReactiveCommand.Create<string>(x => AddNewTask(x));
            DeleteCommand = ReactiveCommand.Create<Task>(x => DeleteTask(SelectedTask));
            CompleteCommand = ReactiveCommand.Create<Task>(x => DeleteTask(SelectedTask));
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

        public DateTime ContentDate
        {
            get { return contentDate; }
            set => this.RaiseAndSetIfChanged(ref contentDate, value);
        }

        public string DateLabel
        {
             get
             {
                var curMonth =  DateTime.Now.ToString("MMMM");
                var curDay =  DateTime.Now.ToString("dd");
                var curYear = DateTime.Now.ToString("yyyy");
                var dateLabel = curMonth + " " + curDay + ", " + curYear;
                return dateLabel;
             }
        }

        public DateTime CurrentDate
        {
            get
            {
                return DateTime.Now.Date;
            }
        }

        public bool IsOverdue
        {
            get
            {
                return isOverdue;
            }
            set => this.RaiseAndSetIfChanged(ref isOverdue, value);
        }
        public bool IsComplete
        {
            get
            {
                return isComplete;
            }
            set => this.RaiseAndSetIfChanged(ref isComplete, value);
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
            if (string.IsNullOrWhiteSpace(ContentName))
            {
                // display error message
                System.Windows.MessageBox.Show("Please enter a name for the new task", "Error");
                return;
            }       


            // create new task object
            var newTask = new Task { Name = ContentName, Date = ContentDate };

            //If task date is earlier than today's date
            if (ContentDate < CurrentDate)
            {
                //mark as overdue
                newTask.IsOverdue = true;
            }
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
        public void MarkTaskComplete(Task task)
        {
            if (task != null)
            {
                try
                {
                    // remove task from list
                    task.IsComplete = true;
                }
                catch (Exception)
                {
                    System.Windows.MessageBox.Show("Error marking task as complete", "Error");
                }

            }

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
                    System.Windows.MessageBox.Show("Error deleting task", "Error");
                }
                
            }

        }
    } 
}
