using System.ComponentModel.DataAnnotations;

namespace ITEC245__ToDo_App_Final_Project__.Models
{
    public class Task
    {
        public enum TaskProgress { Unassigned, None, InProgress, Complete, OnHold }

        [Key]
        public int TaskId { get; set; }

        [Required]
        public string TaskName { get; set; }

        public string TaskDescription { get; set; }

        [Required]
        public TaskProgress Status { get; set; } = TaskProgress.None;
    }
}
