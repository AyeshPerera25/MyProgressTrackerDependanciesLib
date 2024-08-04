using MyProgressTrackerDependanciesLib.Models.DataTransferObjects;

namespace MyProgressTrackerDependanciesLib.Models.DataTransferObjects
{
	public class ProgressReportRes : ResponseWrapper
	{
		public List<ProgressReport>? ProgressReports { get; set; }
	}
}
