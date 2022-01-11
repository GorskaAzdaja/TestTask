using TodoApi.Models.Enums;

namespace TodoApi.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public ProjectStatus ProjectStatus { get; set; }
        public Priority Priority { get; set; } 
        public Task Task { get; set; }

    }
}
