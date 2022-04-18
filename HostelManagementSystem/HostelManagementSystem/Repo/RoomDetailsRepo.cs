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
    public class RoomDetailsRepo:IRoomDetails
    {
        HostelDbContext _context;
        public RoomDetailsRepo(HostelDbContext context)
        {
            _context = context;
        }

        public List<RoomDetailsVM> GetRoomDetails()
        {
            //return _context.RoomDetails.ToList();
            var result = (from a in _context.RoomDetails
                          select new RoomDetailsVM
                          {
                              RoomNo = a.RoomNo,
                              RoomSize = a.RoomSize,
                          }).ToList();
            return result;
        }

        public RoomDetails GetRoomDetailsByNo(int RoomNo)
        {
            return _context.RoomDetails.FirstOrDefault(a => a.RoomNo == RoomNo);
        }

        public void AddRoom(RoomDetails roomDetails)
        {
            _context.Add(roomDetails);
            _context.SaveChanges();
        }

        public void UpdateRoom(RoomDetails roomDetails)
        {
            _context.Update(roomDetails);
            _context.SaveChanges();
        }

        public void DeleteRoom(int RoomNo)
        {
            var delroom = _context.RoomDetails.Where(s => s.RoomNo == RoomNo).FirstOrDefault();
            if (delroom != null)
            {
                _context.Remove(delroom);
                _context.SaveChanges();
            }
        }
    }
}
