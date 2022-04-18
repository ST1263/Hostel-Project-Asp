using HostelManagementSystem.Infra;
using HostelManagementSystem.Model;
using HostelManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementSystem.Service
{
    public class RoomAllocationService
    {
        IRoomAllocation _service;
        public RoomAllocationService(IRoomAllocation service)
        {
            _service = service;
        }

        public List<RoomAllocationVM> GetRoomAllocations()
        {
            return _service.GetRoomAllocations().ToList();
        }

        public RoomAllocation GetRoomAllocationByNo(int RoomAllocationNo)
        {
            return _service.GetRoomAllocationByNo(RoomAllocationNo);
        }

        public void AddRoomAllocation(RoomAllocationVM roomAllocationVM)
        {
            RoomAllocation roomAllocation = new RoomAllocation()
            {
                Id = roomAllocationVM.Id,
                RoomAllocationNo = roomAllocationVM.RoomAllocationNo,
                AdmissionId = roomAllocationVM.AdmissionId,
            };
            _service.AddRoomAllocation(roomAllocation);
        }

        public void UpdateRoomAllocation(RoomAllocationVM roomAllocationVM)
        {
            RoomAllocation roomAllocation = new RoomAllocation()
            {
                Id = roomAllocationVM.Id,
                RoomAllocationNo = roomAllocationVM.RoomAllocationNo,
                AdmissionId = roomAllocationVM.AdmissionId,
            };
            _service.AddRoomAllocation(roomAllocation);
        }

        public void DeleteRoomAllocation(int Id)
        {
            _service.DeleteRoomAllocation(Id);
        }
    }
}
