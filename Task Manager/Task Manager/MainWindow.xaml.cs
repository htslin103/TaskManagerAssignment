using System;
using System.Collections.Generic;
using System.Windows;
using TaskManager.ViewModels;
using TaskManager.Models;

namespace TaskManager
{
   
    public partial class MainWindow : Window
    {
        private List<Task> tasks = new List<Task>();
        Task editTask = new Task();
        TaskViewModel ViewModel;

        public MainWindow()
        {                          
            InitializeComponent();
            ViewModel = new TaskViewModel();
            this.DataContext = ViewModel;
            currentDateLabel();
            btnSave.IsEnabled = false;
            btnEdit.IsEnabled = false;
        }
    
        //States current date
        private void currentDateLabel()
        {          
            lblCurrentDate.Content = "Today's date: " + DateTime.Now.Date.ToLongDateString();
        }

        //Adds New Task
        private void BtnNewTask_Click(object sender, RoutedEventArgs e)
        {
            string taskName = txtTaskName.Text;

            if (dtDateSelect.SelectedDate != null && txtTaskName.Text != "")
            {
                if (dtDateSelect.SelectedDate.Value.Date < DateTime.Now.Date)
                {
                    Task overdueTask = new Task() { Date = dtDateSelect.SelectedDate.Value.Date.ToString("yyyy/MM/dd"), Name = taskName.ToString() };
                    overdueTask.isOverdue = true;
                    tasks.Add((Task)overdueTask);
                }
                else
                {
                    tasks.Add(new Task(dtDateSelect.SelectedDate.Value.Date.ToString("yyyy/MM/dd"), taskName.ToString()));
                }
                liViewTasks.ItemsSource = tasks;
                txtTaskName.Clear();
                liViewTasks.Items.Refresh();
                btnEdit.IsEnabled = true;
            }
            else if (dtDateSelect.SelectedDate == null)
            {
                MessageBox.Show("Date is required", "No date entered");
            }
            else if (string.IsNullOrEmpty(taskName))
            {
                MessageBox.Show("Task name is required", "No task name");
            }
        }

        //Deletes Task
        private void BtnDeleteTask_Click(object sender, RoutedEventArgs e)
        {
            if (liViewTasks.HasItems && liViewTasks.SelectedItem != null)
            {
                tasks.Remove((Task)liViewTasks.SelectedItem);
                liViewTasks.Items.Refresh();
            }           
        }

        private void BtnComplete_Click(object sender, RoutedEventArgs e)
        {
            if (liViewTasks.HasItems && liViewTasks.SelectedItem != null)
            {
                Task compTask = ((Task)liViewTasks.SelectedItem);
                compTask.isComplete = true;
                tasks.Add((Task)compTask);
                tasks.Remove((Task)liViewTasks.SelectedItem);
                liViewTasks.Items.Refresh();
            }
        }
        //User clicks edit
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (liViewTasks.SelectedItem != null)
            {
                editTask = ((Task)liViewTasks.SelectedItem);
                txtTaskName.Text = editTask.Name.ToString();
                dtDateSelect.Text = editTask.Date.ToString();
                btnSave.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Task must be selected to edit", "Error");
            }
        }
        //User clicks save
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

            if (dtDateSelect.SelectedDate != null && txtTaskName.Text != "")
            {
                tasks.Remove((Task)liViewTasks.SelectedItem);
                string taskName = txtTaskName.Text.ToString();
                if (dtDateSelect.SelectedDate.Value.Date < DateTime.Now.Date)
                {
                    Task overdueTask = new Task() { Date = dtDateSelect.SelectedDate.Value.Date.ToString("yyyy/MM/dd"), Name = taskName };
                    overdueTask.isOverdue = true;
                    tasks.Add((Task)overdueTask);
                }
                else
                {
                    tasks.Add(new Task(dtDateSelect.SelectedDate.Value.Date.ToString("yyyy/MM/dd"), taskName));
                }

                liViewTasks.ItemsSource = tasks;
                liViewTasks.Items.Refresh();
                txtTaskName.Clear();
                btnSave.IsEnabled = false;

            }
            else if (dtDateSelect.SelectedDate == null)
            {
                MessageBox.Show("Date is required", "No date entered");
            }
            else if (string.IsNullOrEmpty(txtTaskName.Text))
            {
                MessageBox.Show("Task name is required", "No task name");
            }
        }
    }
}