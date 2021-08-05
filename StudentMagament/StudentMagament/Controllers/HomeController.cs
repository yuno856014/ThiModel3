using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentMagament.Models;
using StudentMagament.Servicess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMagament.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClassRoomService classRoomService;

        public HomeController(IClassRoomService classRoomService)
        {
            this.classRoomService = classRoomService;
        }

        public IActionResult Index()
        {
            return View(classRoomService.GetClassRooms());
        }
    }
}
