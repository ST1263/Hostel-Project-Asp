using HostelManagementSystem.Infra;
using HostelManagementSystem.Model;
using HostelManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementSystem.Service
{
    public class AdmissionService
    {
        IAdmission _service;
        public AdmissionService(IAdmission service)
        {
            _service = service;
        }

        public List<AdmissionVM>GetAdmissions()
        {
            return _service.GetAdmissions().ToList();
        }

        public AdmissionVM GetAdmissionById(int AdmissionId)
        {
            return _service.GetAdmissionById(AdmissionId);
        }

        public void AddAdmission(AdmissionVM admissionvm)
        {
            Admission admission = new Admission()
            {
                AdmissionId = admissionvm.AdmissionId,
                FullName = admissionvm.FullName,
                EmailId = admissionvm.EmailId,
                MobileNo = admissionvm.MobileNo,
                DateOfBirth = admissionvm.DateOfBirth,
                BloodGroup = admissionvm.BloodGroup,
                Caste = admissionvm.Caste,
                GuardianName = admissionvm.GuardianName,
                GuardianEmailId = admissionvm.GuardianEmailId,
                GuardianMobileNo = admissionvm.GuardianMobileNo,
                CourseName = admissionvm.CourseName,
                CurrentYear = admissionvm.CurrentYear,
                CollegeName = admissionvm.CollegeName,
                HouseName = admissionvm.HouseName,
                Locality = admissionvm.Locality,
                City = admissionvm.City,
                State = admissionvm.State,
                Country = admissionvm.Country,
                ZipCode = admissionvm.ZipCode,
                createdAT = admissionvm.createdAT,
                createdBy = admissionvm.createdBy,
            };
            _service.AddAdmission(admission);
        }

        public void UpdateAdmission(AdmissionVM admissionvm)
        {
            Admission admission = new Admission()
            {
                AdmissionId = admissionvm.AdmissionId,
                FullName = admissionvm.FullName,
                EmailId = admissionvm.EmailId,
                MobileNo = admissionvm.MobileNo,
                DateOfBirth = admissionvm.DateOfBirth,
                BloodGroup = admissionvm.BloodGroup,
                Caste = admissionvm.Caste,
                GuardianName = admissionvm.GuardianName,
                GuardianEmailId = admissionvm.GuardianEmailId,
                GuardianMobileNo = admissionvm.GuardianMobileNo,
                CourseName = admissionvm.CourseName,
                CurrentYear = admissionvm.CurrentYear,
                CollegeName = admissionvm.CollegeName,
                HouseName = admissionvm.HouseName,
                Locality = admissionvm.Locality,
                City = admissionvm.City,
                State = admissionvm.State,
                Country = admissionvm.Country,
                ZipCode = admissionvm.ZipCode,
                createdAT = admissionvm.createdAT,
                createdBy = admissionvm.createdBy,
            };
            _service.UpdateAdmission(admission);
        }

        public void DeleteAdmission(int AdmissionId)
        {
            _service.DeleteAdmission(AdmissionId);
        }
    }
}
