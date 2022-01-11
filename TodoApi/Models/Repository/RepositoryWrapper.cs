using TodoApi.Models.RepositoryInterface;

namespace TodoApi.Models.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private DatabaseContext _dbContext;
        private IProjectRepository _project;
        private ITaskRepository _task;

        public IProjectRepository ProjectRepository
        {
            get
            {
                if( _project == null)
                {
                    _project = new ProjectRepository(_dbContext);
                }

                return _project;
            }
          
        }

        public ITaskRepository TaskRepository
        {
            get
            {
                if(_task == null)
                {
                    _task = new TaskRepository(_dbContext);
                }

                return _task;
            }
        }

        public RepositoryWrapper(DatabaseContext databaseContext)
        {
            _dbContext = databaseContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
