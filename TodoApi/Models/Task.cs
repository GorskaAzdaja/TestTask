using TodoApi.Models.Enums;

namespace TodoApi.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Enums.TaskStatus TaskStatus { get; set; }
        public Priority Priority { get; set; }

    }
}
