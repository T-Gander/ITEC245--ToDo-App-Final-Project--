using System.ComponentModel.DataAnnotations;

namespace ITEC245__ToDo_App_Final_Project__.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsAdmin { get; set; }
    }
}
