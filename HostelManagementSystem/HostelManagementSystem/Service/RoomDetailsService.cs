using HostelManagementSystem.Infra;
using HostelManagementSystem.Model;
using HostelManagementSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementSystem.Service
{
    public class RoomDetailsService
    {
        IRoomDetails _service;
        public RoomDetailsService(IRoomDetails service)
        {
            _service = service;
        }

        public List<RoomDetailsVM> GetRoomDetails()
        {
            return _service.GetRoomDetails().ToList();
        }

        public RoomDetails GetRoomDetailsByNo(int RoomNo)
        {
            return _service.GetRoomDetailsByNo(RoomNo);
        }

        public void AddRoom(RoomDetailsVM roomDetailsVM)
        {
            RoomDetails roomDetails = new RoomDetails()
            {
                RoomNo = roomDetailsVM.RoomNo,
                RoomSize = roomDetailsVM.RoomSize,
            };
            _service.AddRoom(roomDetails);
        }

        public void UpdateRoom(RoomDetailsVM roomDetailsVM)
        {
            RoomDetails roomDetails = new RoomDetails()
            {
                RoomNo = roomDetailsVM.RoomNo,
                RoomSize = roomDetailsVM.RoomSize,
            };
            _service.UpdateRoom(roomDetails);
        }

        public void DeleteRoom(int RoomNo)
        {
            _service.DeleteRoom(RoomNo);
        }
    }
}
