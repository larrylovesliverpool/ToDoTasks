using ToDoTasks.Repository;
using Interfaces.Service;
using ToDoTasks.Domain.DataTransferObjects;

namespace ToDoTasks.Service
{
    public class ToDoTasksService : IToDoTasksService
    {
        IToDpTasksRepository repo;

        public ToDoTasksService() {

            // remove once ioc created
            repo = new ToDoTasksRepository();
        }

        public ToDoTasksService(IToDpTasksRepository repo) {

            this.repo = repo;
        }

        public ToDoTasksDto Generate()
        {
            ToDoTasksDto dto = new ToDoTasksDto();

            var tasks = repo.ReadTasks();

            // transfer domain model of tasks to dto of tasks

            foreach(var task in tasks)
            {
                dto.ToDoTasks.Add(new ToDoTaskDto { Identifier = task.Identifier, Description = task.Description });
            }

            return dto;
        }

    }
}
