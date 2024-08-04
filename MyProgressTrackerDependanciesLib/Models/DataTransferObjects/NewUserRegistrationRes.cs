using MyProgressTrackerDependanciesLib.Models.Entities;

namespace MyProgressTrackerDependanciesLib.Models.DataTransferObjects
{
    public class NewUserRegistrationRes : ResponseWrapper
    {
        public NewUserRegistrationReq? NewUserRegistrationReq { get; set; }
        public User? User { get; set; }
    }
}
