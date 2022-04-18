using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementSystem.Model
{
    public class RoomDetails
    {
        [Key]
        public int RoomNo { get; set; }
        public int RoomSize { get; set; }   
    }
}
