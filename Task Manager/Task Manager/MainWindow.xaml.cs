using System;
using System.Collections.Generic;
using System.Windows;
using TaskManager.ViewModels;
using TaskManager.Models;

namespace TaskManager
{
   
    public partial class MainWindow : Window
    {
     
        TaskViewModel ViewModel;

        public MainWindow()
        {                          
            InitializeComponent();
            ViewModel = new TaskViewModel();
            this.DataContext = ViewModel;
            currentDateLabel();                     
        }
    
        //States current date
        private void currentDateLabel()
        {          
            lblCurrentDate.Content = "Today's date: " + DateTime.Now.Date.ToLongDateString();
        }

    }
}