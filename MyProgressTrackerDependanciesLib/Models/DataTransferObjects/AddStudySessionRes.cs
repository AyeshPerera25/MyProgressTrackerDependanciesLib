﻿using MyProgressTrackerDependanciesLib.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgressTrackerDependanciesLib.Models.DataTransferObjects
{
	public class AddStudySessionRes : ResponseWrapper
	{
		public StudySession? StudySession { get; set; }
	}
}
