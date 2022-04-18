using HostelManagementSystem.Model;
using HostelManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementSystem.Infra
{
    public interface IRoomDetails
    {
        public List<RoomDetailsVM> GetRoomDetails();
        public RoomDetails GetRoomDetailsByNo(int RoomNo);
        public void AddRoom(RoomDetails roomDetails);
        public void UpdateRoom(RoomDetails roomDetails);
        public void DeleteRoom(int RoomNo);
    }
}
