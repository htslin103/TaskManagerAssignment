using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TaskManager.ViewModels;

namespace TaskManager.Classes
{
    internal class TaskUpdateCommand: ICommand
    {

        private TaskViewModel _ViewModel;

        public TaskUpdateCommand(TaskViewModel viewModel)
        {
            _ViewModel = viewModel; 
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _ViewModel.CanUpdate;
        }

        public void Execute(object parameter)
        {
            _ViewModel.SaveChanges();
        }
    }
}
