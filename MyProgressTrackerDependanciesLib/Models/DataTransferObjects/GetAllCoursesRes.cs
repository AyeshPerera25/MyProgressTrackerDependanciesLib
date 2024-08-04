using MyProgressTrackerDependanciesLib.Models.DataTransferObjects;
using MyProgressTrackerDependanciesLib.Models.Entities;

namespace MyProgressTrackerDependanciesLib.Models.DataTransferObjects
{
	public class GetAllCoursesRes : ResponseWrapper
	{
		public List<Course>? CourseList { get; set; }
	}
}
