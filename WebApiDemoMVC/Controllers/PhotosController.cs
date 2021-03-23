﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApiDemoMVC.Models;
using WebApiDemoMVC.Models.ViewModels;

namespace WebApiDemoMVC.Controllers
{
    public class PhotosController : Controller
    {
        PhotosService service;

        public PhotosController(PhotosService service)
        {
            this.service = service;
        }

        [Route("")]
        [Route("index")]
        public async Task<IActionResult> Index()
        {

            var VM = await service.GetAllPhotos();

            return View(VM);
        }
    }
}
