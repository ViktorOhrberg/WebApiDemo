using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAPI.Controllers
{

    [ApiController]
    //[Route("[controller]")]

    public class ApiPhotoController : ControllerBase
    {
        ApiPhotosService service;

        public ApiPhotoController(ApiPhotosService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("")]
        [Route("photos")]

        public ActionResult<Photo[]> Index()
        {
            var model = service.GetPhotos();
            if (model != null)
                return model;
            else
                return BadRequest($"Error");
        }
    }
}
