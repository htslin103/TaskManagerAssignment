using DynamicData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TaskManager.Models;

namespace TaskManager.Models
{
    public class TaskService
    {
        private static ObservableCollection<Task> ObjTaskList;

        public TaskService()
        {
            ObjTaskList = new ObservableCollection<Task>()
            {
                new Task { Id=1, Date = "01/10/2020" , Name = "Fight stuff"},
                new Task { Id=2, Date = "02/10/2020" , Name = "Cook stuff"},
                new Task { Id=3, Date = "03/10/2020" , Name = "Destroy stuff"}
            };
        }     

        
        public bool Add(Task objNewTask)
        {
            ObjTaskList.Add(objNewTask);
            return true;
        }

        public ObservableCollection<Task> GetAll()
        {
            return ObjTaskList;
        }

        public bool Update(Task objTaskToUpdate)
        {
            bool IsUpdated = false;

            for(int index=0; index<ObjTaskList.Count; index++)
            {
                if(ObjTaskList[index].Id == objTaskToUpdate.Id)
                {
                    ObjTaskList[index].Date = objTaskToUpdate.Date;
                    ObjTaskList[index].Name = objTaskToUpdate.Name;
                    IsUpdated = true;
                    break;
                }
            }
            return IsUpdated;
        }

        public bool Delete(int id)
        {
            bool IsDeleted = false; 

            for (int index = 0; index < ObjTaskList.Count; index++)
            {
                if(ObjTaskList[index].Id == id)
                {
                    ObjTaskList.RemoveAt(index);
                    IsDeleted = true;
                    break;
                }
            }

            return IsDeleted;
        }

    }
}
