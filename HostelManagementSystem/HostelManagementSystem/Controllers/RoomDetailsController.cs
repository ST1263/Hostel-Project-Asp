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
    public class RoomDetailsController : Controller
    {
        RoomDetailsService _repo;
        public RoomDetailsController(RoomDetailsService repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("GetRoomDetails")]
        public IActionResult GetRoomDetails()
        {
            var allrooms = _repo.GetRoomDetails();
            return Ok(allrooms);
        }

        [HttpGet]
        [Route("GetRoomDetailsByNo")]
        public IActionResult GetRoomDetailsByNo(int RoomNo)
        {
            var result = _repo.GetRoomDetailsByNo(RoomNo);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddRoom")]
        public IActionResult AddRoom([FromBody] RoomDetailsVM roomDetails)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Room Details Failed! Please check your details and try again." });
                    //return BadRequest();
                }
                _repo.AddRoom(roomDetails);
                //return Ok();
                return Ok(new Response { Status = "Success", Message = "Room Details Add successfully!" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateRoom")]
        public IActionResult UpdateRoom(RoomDetailsVM roomDetails)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Update Failed! Please check your details and try again." });
                    //return BadRequest();
                }
                _repo.UpdateRoom(roomDetails);
                return Ok(new Response { Status = "Success", Message = "Update Room Details successfully!" });
                //return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteRoom/{RoomNo}")]
        public IActionResult DeleteRoom(int RoomNo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Delete Failed! Please check your details and try again." });
                    //return BadRequest();
                }
                _repo.DeleteRoom(RoomNo);
                return Ok(new Response { Status = "Success", Message = "Delete Romm Details successfully!" });
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
