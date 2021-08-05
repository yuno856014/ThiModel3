using StudentMagament.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMagament.Servicess
{
    public interface IClassRoomService
    {
        public List<ClassRoom> GetClassRooms();
        public ClassRoom GetClassRoomById(int classRoomid);
    }
}
