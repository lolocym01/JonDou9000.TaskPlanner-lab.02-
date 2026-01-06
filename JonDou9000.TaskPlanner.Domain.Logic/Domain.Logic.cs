using JonDou9000.TaskPlanner.Domain.Models;
using JonDou9000.TaskPlanner.DataAccess.Abstractions;

namespace JonDou9000.TaskPlanner.Domain.Logic
{
    public class SimpleTaskPlanner
    {
        private readonly IWorkItemsRepository _repository;

        public SimpleTaskPlanner(IWorkItemsRepository repository)
        {
            _repository = repository;
        }

        public WorkItem[] CreatePlan()
        {
            var items = _repository.GetAll();
            return items;
        }
    }
}
