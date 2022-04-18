using HostelManagementSystem.Model;
using HostelManagementSystem.Service;
using HostelManagementSystem.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementSystem.Controllers
{
    /*[Authorize]*/
    [Route("api/[controller]")]
    [ApiController]
    public class RoomAllocationController : Controller
    {
        RoomAllocationService _repo;
        public RoomAllocationController(RoomAllocationService repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("GetRoomAllocations")]
        public IActionResult GetRoomAllocations()
        {
            var allroomallocation = _repo.GetRoomAllocations();
            return Ok(allroomallocation);
        }

        [HttpGet]
        [Route("GetRoomAllocationByNo")]
        public IActionResult GetRoomAllocationByNo(int RoomAllocationNo)
        {
            var result = _repo.GetRoomAllocationByNo(RoomAllocationNo);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddRoomAllocation")]
        public IActionResult AddRoomAllocation([FromBody] RoomAllocationVM roomAllocationVM)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Room Allocation Failed! Please check your details and try again." });
                    //return BadRequest();
                }
                _repo.AddRoomAllocation(roomAllocationVM);
                //return Ok();
                return Ok(new Response { Status = "Success", Message = "Room Allocation successfully!" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateRoomAllocation")]
        public IActionResult UpdateRoomAllocation(RoomAllocationVM roomAllocationVM)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Update Failed! Please check your details and try again." });
                    //return BadRequest();
                }
                _repo.UpdateRoomAllocation(roomAllocationVM);
                return Ok(new Response { Status = "Success", Message = "Update successfully!" });
                //return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteRoomAllocation/{Id}")]
        public IActionResult DeleteRoomAllocation(int Id)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Delete Failed! Please check your details and try again." });
                    //return BadRequest();
                }
                _repo.DeleteRoomAllocation(Id);
                return Ok(new Response { Status = "Success", Message = "Delete successfully!" });
                //return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
