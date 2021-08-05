using Microsoft.AspNetCore.Mvc;
using StudentMagament.Models.ClassRoom;
using StudentMagament.Servicess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMagament.Controllers
{
    public class ClassRoomController : Controller
    {
        private readonly IClassRoomService classRoomService;

        public ClassRoomController(IClassRoomService classRoomService)
        {
            this.classRoomService = classRoomService;
        }
        public IActionResult Index()
        {
            var classroom = classRoomService.GetClassRooms();
            var classview = new ClassRoomView()
            {
                ClassRooms = classroom
            };
            return View(classview);
        }
    }
}
