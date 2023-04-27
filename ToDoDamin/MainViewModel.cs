using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ToDoDamin
{
    public class MainViewModel : BindableBase
    {
        //test
        public ObservableCollection<TaskModel> Tasks { get; } = new ObservableCollection<TaskModel>();

        public ICommand AddTaskCommand { get; }

        public MainViewModel() 
        {
            AddTaskCommand = new DelegateCommand(AddTask);
        }

        private void AddTask() 
        {
            var addTaskWindow = new AddTaskWindow();
            if (addTaskWindow.ShowDialog() == true) 
            {
                Tasks.Insert(0, new TaskModel(addTaskWindow.StartDate.GetValueOrDefault(),addTaskWindow.EndDate.GetValueOrDefault(),addTaskWindow.Description));
            }
        }
    }
}
