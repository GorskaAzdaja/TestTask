using TodoApi.Models.RepositoryInterface;

namespace TodoApi.Models.Repository
{
    public class ProjectRepository : RepositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
