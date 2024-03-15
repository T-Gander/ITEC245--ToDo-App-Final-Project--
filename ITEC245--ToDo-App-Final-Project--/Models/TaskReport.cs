using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITEC245__ToDo_App_Final_Project__.Models
{
    
    public class TaskReport
    {
        [Required]
        [ForeignKey("Task")]
        public int TaskID { get; set; }

        [Required]
        public string Report { get; set; }

        public Task Task { get; set; }
    }
    
    
}
