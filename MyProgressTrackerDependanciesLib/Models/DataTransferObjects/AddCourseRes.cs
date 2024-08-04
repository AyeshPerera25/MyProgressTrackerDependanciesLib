using MyProgressTrackerDependanciesLib.Models.DataTransferObjects;
using MyProgressTrackerDependanciesLib.Models.Entities;

namespace MyProgressTrackerDependanciesLib.Models.DataTransferObjects
{
	public class AddCourseRes : ResponseWrapper
	{
		public Course? course { get; set; } = null;
	}
}
