using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgressTrackerDependanciesLib.Models.DataTransferObjects
{
    public class DeleteStudySessionReq : RequestWrapper
    {
        [Required]
        public int StudySessionId { get; set; }
    }
}
