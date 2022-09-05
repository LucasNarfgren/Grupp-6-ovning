using Microsoft.AspNetCore.Identity;

namespace Grupp6_ovning.Models
{
    public class Employee : IdentityUser
    {


        public int UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }


        public string Email { get; set; }
        public string PassWord { get; set; }


        public int VacationDays { get; set; }


        public List<Application> Applications { get; set; }

        
    }
}
