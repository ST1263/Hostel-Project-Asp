using HostelManagementSystem.Model;
using HostelManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementSystem.Infra
{
    public interface IAdmission
    {
        public List<AdmissionVM> GetAdmissions();
        public AdmissionVM GetAdmissionById(int AdmissionId);
        public void AddAdmission(Admission admission);
        public void UpdateAdmission(Admission admission);
        public void DeleteAdmission(int AdmissionId);
    }
}
