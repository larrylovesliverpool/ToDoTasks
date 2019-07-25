using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TryItOut.CommonInterfaces;
using TryItOut.Domain;
using TryItOut.Domain.Models;

namespace TryItOut.DataAccess
{
    public class ToDoTasksRepository : IToDoTasksRepository
    {
        public bool Delete(ToDoTask entity)
        {
            throw new NotImplementedException();
        }

        public ToDoTask Read(int identifier)
        {
            throw new NotImplementedException();
        }

        public IList<ToDoTask> Read()
        {
            IList<ToDoTask> tasks = new List<ToDoTask>();
            string filePath = HttpContext.Current.Server.MapPath("~/App_Data/toDoTasks.xml");

            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(tasks.GetType());
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);

            tasks = (List<ToDoTask>)reader.Deserialize(file);

            file.Close();

            return tasks;
        }

        public bool Save(ToDoTask entity)
        {
            throw new NotImplementedException();
        }
    }

}
