using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ITEC245__ToDo_App_Final_Project__.Models
{
    public class TaskTeam
    {
        [Required]
        [ForeignKey("Task")]
        public int TaskID { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserID { get; set; }

        public Task Task { get; set; }

        public User User { get; set; }
    }
}
