namespace TodoApi.Models.RepositoryInterface
{
    public interface IRepositoryWrapper
    {
        IProjectRepository ProjectRepository { get; }
        ITaskRepository TaskRepository { get; }
        void Save();
    }
}
