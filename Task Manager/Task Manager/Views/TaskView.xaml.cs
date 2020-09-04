using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TaskManager.ViewModels;
using ReactiveUI;
using System.Reactive.Disposables;
using ReactiveUI.Fody.Helpers;

namespace TaskManager.Views
{
    /// <summary>
    /// Interaction logic for TaskView.xaml
    /// </summary>
    public partial class TaskView : IViewFor<TaskViewModel>
    {
        public TaskView()
        {

            InitializeComponent();
            ViewModel = new TaskViewModel();

            //Item bindings 
            this.Bind(ViewModel, vm => vm.ContentName, v => v.NameTextBox.Text);
            this.Bind(ViewModel, vm => vm.ContentDate, v => v.taskDatePicker.Text);
            this.OneWayBind(ViewModel, vm => vm.CurrentDate, v => v.currentDateTxtBlock.Text);
            this.Bind(ViewModel, vm => vm.SelectedTask, view => view.tasksDataGrid.SelectedItem);



            //Data Grid
            this.WhenActivated(disposable =>
            {
                this.OneWayBind(ViewModel, x => x.TaskList, x => x.tasksDataGrid.ItemsSource).DisposeWith(disposable);
            });
            
            //Add button click
            this.WhenActivated(disposable =>
            {
                this.BindCommand(this.ViewModel, vm => vm.AddCommand, v => v.AddNewTaskbtn).DisposeWith(disposable);
            });
            //Delete button click 
            this.WhenActivated(disposable =>
            {
                this.BindCommand(this.ViewModel, vm => vm.DeleteCommand, v => v.DeleteTaskbtn).DisposeWith(disposable);
            });


        }

    }
}

