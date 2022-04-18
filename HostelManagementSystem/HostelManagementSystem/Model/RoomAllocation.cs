using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementSystem.Model
{
    public class RoomAllocation
    {
        public int Id { get; set; }
        public int RoomAllocationNo { get; set; }
        public int AdmissionId { get; set; }    
        public virtual Admission Admission { get; set; }
    }
}
