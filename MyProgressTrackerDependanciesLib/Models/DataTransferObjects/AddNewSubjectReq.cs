using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgressTrackerDependanciesLib.Models.DataTransferObjects
{
	public class AddNewSubjectReq : RequestWrapper
	{
		[Required]
		public string SubjectName { get; set; }
		[Required]
		public int CourseID { get; set; }
		[Required]
		public int SemesterNo { get; set; }
		public string? Description { get; set; }
		[Required]
		public DateTime SemesterStartDate { get; set; }
		[Required]
		public DateTime SemesterEndDate { get; set; }
	}
}
