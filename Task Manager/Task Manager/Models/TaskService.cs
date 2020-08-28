using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Models;

namespace Task_Manager.Models
{
    public class TaskService
    {
        private static List<Task> ObjTaskList; 

        public TaskService()
        {
            ObjTaskList = new List<Task>();
        }

        //Must set date overdue here
        public bool Add(Task objNewTask)
        {
            ObjTaskList.Add(objNewTask);
            return true;
        }

        public List<Task> GetAll()
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
