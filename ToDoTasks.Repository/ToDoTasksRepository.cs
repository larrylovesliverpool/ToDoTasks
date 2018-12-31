using System;
using System.Collections.Generic;
using System.Web;
using System.Xml;
using ToDoTasks.Domain;

namespace ToDoTasks.Repository
{
    public class ToDoTasksRepository : IToDpTasksRepository
    {
        public IList<ToDoTask> ReadTasks()
        {
            IList<ToDoTask> tasks = new List<ToDoTask>();

            //Load the XML file in XmlDocument.
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(HttpContext.Current.Server.MapPath("~/App_Data/XMLFileToDoTasks.xml"));

            //Loop through the selected Nodes.
            foreach (XmlNode node in xmlDoc.SelectNodes("/Tasks/Task"))
            {
                //Fetch the Node values and assign it to Model.
                tasks.Add(new ToDoTask()
                {
                    Identifier = int.Parse(node["Id"].InnerText),
                    Description = node["Description"].InnerText,
                    Completed = Convert.ToBoolean(node["Completed"].InnerText),
                    Deleted = Convert.ToBoolean(node["Deleted"].InnerText)
                });
            }

            return tasks;
        }
    }
}
