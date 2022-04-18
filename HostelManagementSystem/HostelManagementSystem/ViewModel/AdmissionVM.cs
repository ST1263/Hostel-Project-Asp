using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HostelManagementSystem.ViewModel
{
    public class AdmissionVM
    {
        public int AdmissionId { get; set; }
        public string FullName { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string DateOfBirth { get; set; }
        public string BloodGroup { get; set; }
        public string Caste { get; set; }
        public string GuardianName { get; set; }
        public string GuardianEmailId { get; set; }
        public string GuardianMobileNo { get; set; }
        public string CollegeName { get; set; }
        public string CourseName { get; set; }
        public string CurrentYear { get; set; }
        public string HouseName { get; set; }
        public string Locality { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }
        public DateTime createdAT { get; set; }
        public string createdBy { get; set; }
        public int RoomAllocationNo { get; set; }
    }
}
