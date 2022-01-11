using TodoApi.Models.RepositoryInterface;

namespace TodoApi.Models.Repository
{
    public class TaskRepository : RepositoryBase<Task>, ITaskRepository
    {
        public TaskRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
