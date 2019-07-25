using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TryItOut.Domain;
using TryItOut.Domain.Models;

namespace TryItOut.DataAccess
{
    public class XMLReadWrite
    {
        public void Write(ToDoTask contents)
        {
            var writer = new System.Xml.Serialization.XmlSerializer(contents.GetType());

            string filePath = HttpContext.Current.Server.MapPath("~/App_Data/toDoTasks.xml");

            var wfile = new System.IO.StreamWriter(filePath);
            writer.Serialize(wfile, contents);
            wfile.Close();
        }

        public void Write(IList<ToDoTask> contents)
        {
            var writer = new System.Xml.Serialization.XmlSerializer(contents.GetType());

            string filePath = HttpContext.Current.Server.MapPath("~/App_Data/toDoTasks.xml");

            var wfile = new System.IO.StreamWriter(filePath);
            writer.Serialize(wfile, contents);
            wfile.Close();
        }

        public IList<ToDoTask> Read()
        {
            IList<ToDoTask> tasks = new List<ToDoTask>();
            string filePath = HttpContext.Current.Server.MapPath("~/App_Data/toDoTasks.xml");

            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(tasks.GetType());
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);

            //IList<ToDoTask> overview = (List<ToDoTask>)reader.Deserialize(file);

            tasks = (List<ToDoTask>)reader.Deserialize(file);

            file.Close();

            return tasks;

        }
    }
}
