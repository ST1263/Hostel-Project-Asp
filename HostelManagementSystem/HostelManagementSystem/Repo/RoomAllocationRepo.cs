using HostelManagementSystem.Data;
using HostelManagementSystem.Infra;
using HostelManagementSystem.Model;
using HostelManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementSystem.Repo
{
    public class RoomAllocationRepo:IRoomAllocation
    {
        HostelDbContext _context;
        public RoomAllocationRepo(HostelDbContext context)
        {
            _context = context;
        }

        public List<RoomAllocationVM> GetRoomAllocations()
        {
            //return _context.Admission.ToList();
            var result = (from a in _context.RoomAllocation
                          select new RoomAllocationVM
                          {
                              Id = a.Id,
                              RoomAllocationNo = a.RoomAllocationNo,
                              AdmissionId = a.AdmissionId,
                          }).ToList();
            return result;
        }

        public RoomAllocation GetRoomAllocationByNo(int RoomAllocationNo)
        {
            return _context.RoomAllocation.FirstOrDefault(a => a.RoomAllocationNo == RoomAllocationNo);

        }

        public void AddRoomAllocation(RoomAllocation roomAllocation)
        {
            _context.Add(roomAllocation);
            _context.SaveChanges();
        }

        public void UpdateRoomAllocation(RoomAllocation roomAllocation)
        {
            _context.Update(roomAllocation);
            _context.SaveChanges();
        }

        public void DeleteRoomAllocation(int Id)
        {
            var delroomallocate = _context.RoomAllocation.Where(s => s.Id == Id).FirstOrDefault();
            if (delroomallocate != null)
            {
                _context.Remove(delroomallocate);
                _context.SaveChanges();
            }
        }
    }
}
