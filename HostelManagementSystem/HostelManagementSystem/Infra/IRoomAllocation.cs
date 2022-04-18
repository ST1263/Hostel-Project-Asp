using HostelManagementSystem.Model;
using HostelManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementSystem.Infra
{
    public interface IRoomAllocation
    {
        public List<RoomAllocationVM> GetRoomAllocations();
        public RoomAllocation GetRoomAllocationByNo(int RoomAllocationNo);
        public void AddRoomAllocation(RoomAllocation roomAllocation);
        public void UpdateRoomAllocation(RoomAllocation roomAllocation);
        public void DeleteRoomAllocation(int Id);
    }
}
