using System.ComponentModel.DataAnnotations;

namespace CMCSProject.Models
{
	public class Claim
	{
		public int Id { get; set; }	

		[Required]
		[Display(Name ="Lecturer Name")]
		public string LecturerName { get; set; }

		[Required]
		[Display(Name ="Hours Worked")]
		public string HoursWorked { get; set; }
		
		[Required]
		[Display(Name ="Hourly Rate")]
		public string HourlyRate { get; set; }

		[Display(Name = "Status")]
		public string Status { get; set; } = "Pending";

		[Display(Name ="Uploaded Document")]
		public string UploadedDocument { get; set; }
	}
}
