using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgressTrackerDependanciesLib.Models.DataTransferObjects
{
    public class DeleteCoursReq : RequestWrapper
    {
        [Required]
        public int CourseId { get; set; }
    }
}
