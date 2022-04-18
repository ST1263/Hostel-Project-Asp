using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HostelManagementSystem.Model
{
    public class Admission
    {
        [Key]
        public int AdmissionId { get; set; }
        [MaxLength(30)]
        public string FullName { get; set; }
        [MaxLength(35)]
        public string EmailId { get; set; }
        [MaxLength(10)]
        public string MobileNo { get; set; }
        public string DateOfBirth { get; set; }
        [MaxLength(10)]
        public string BloodGroup { get; set; }
        [MaxLength(10)]
        public string Caste { get; set; }
        [MaxLength(30)]
        public string GuardianName { get; set; }
        [MaxLength(35)]
        public string GuardianEmailId { get; set; }
        [MaxLength(10)]
        public string GuardianMobileNo { get; set; }
        [MaxLength(30)]
        public string CollegeName { get; set; }
        [MaxLength(20)]
        public string CourseName { get; set; }
        [MaxLength(10)]
        public string CurrentYear { get; set; }
        [MaxLength(10)]
        public string HouseName { get; set; }
        [MaxLength(15)]
        public string Locality { get; set; }
        [MaxLength(15)]
        public string City { get; set; }
        [MaxLength(15)]
        public string State { get; set; }
        [MaxLength(15)]
        public string Country { get; set; }
        [MaxLength(6)]
        public int ZipCode { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime createdAT { get; set; }
        [MaxLength(25)]
        public string createdBy { get; set; }
        [JsonIgnore]
        public virtual RoomAllocation RoomAllocation { get; set; }
    }
}
