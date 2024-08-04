using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgressTrackerDependanciesLib.Models.DataTransferObjects
{
	public class AddStudySessionReq : RequestWrapper
	{
		[Required]
		public string SessionName { get; set; }
		[Required]
		public int SubjectID { get; set; }
		public string? SessionDescription { get; set; }
		[Required]
		public DateTime SessionStartTime { get; set; }
		[Required]
		public DateTime SessionEndTime { get; set; }
	}
}
