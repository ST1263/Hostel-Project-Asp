﻿using HostelManagementSystem.Infra;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementSystem.Controllers
{
    /*[Authorize]*/
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : Controller
    {
        #region Property  
        private readonly IFileService _fileService;  
        #endregion  
 
        #region Constructor  
        public FileController(IFileService fileService)  
        {  
            _fileService = fileService;  
        }  
        #endregion  
 
        #region Upload  
        [HttpPost(nameof(Upload))]  
        public IActionResult Upload([Required] List<IFormFile> formFiles, [Required] string subDirectory)  
        {  
            try  
            {  
                _fileService.UploadFile(formFiles, subDirectory);  
                return Ok(new { formFiles.Count, Size = _fileService.SizeConverter(formFiles.Sum(f => f.Length)) });  
            }  
            catch (Exception ex)  
            {  
                return BadRequest(ex.Message);  
            }  
        }  
        #endregion  
 
        #region Download File  
        [HttpGet(nameof(Download))]  
        public IActionResult Download([Required]string subDirectory)  
        {  
            try  
            {  
                var (fileType, archiveData, archiveName) = _fileService.DownloadFiles(subDirectory);  
  
                return File(archiveData, fileType, archiveName);  
            }  
            catch (Exception ex)  
            {  
                return BadRequest(ex.Message);  
            }  
        }  
        #endregion  
       /* public IActionResult Index()
        {
            return View();
        }*/
    }
}