using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Grupp6_ovning.Models
{
    public class Application
    {
        [Key]
        public int ApplicationId { get; set; }

        [Required]
        public int LeaveTypeId { get; set; }
        public LeaveType LeaveType { get; set; }

        [Required]
        [DisplayFormat(DataFormatString ="0:MM:dd:yy")]
        public DateTime StartDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "0:MM:dd:yy")]
        public DateTime EndDate { get; set; }

        [BindNever]
        [DataType(DataType.DateTime)]
        public DateTime RequestDate { get; set; }

        
        public int RequestId { get; set; }
        public Request Request { get; set;}

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }  
    }
}
