using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TryItOut.Domain;

namespace TryItOut.Areas.ToDoTasks_API.Contollers
{
    public class ToDoTasksController : ApiController
    {
        [System.Web.Mvc.Route("api/ToDoTasks")]
        public IHttpActionResult GetToDoTasks()
        {
            var model = new Person();

            return Ok(model);
        }


        [System.Web.Mvc.Route("api/ToDoTask")]
        public IHttpActionResult GetToDoTasks(int identifier)
        {
            var model = new Person();

            return Ok(model);
        }

    }
}
