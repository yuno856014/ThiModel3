using Microsoft.EntityFrameworkCore;
using StudentMagament.DBContextts;
using StudentMagament.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMagament.Servicess
{
    public class ClassRoomService : IClassRoomService
    {
        private readonly StudentMagamentDBContext context;

        public ClassRoomService(StudentMagamentDBContext context)
        {
            this.context = context;
        }

        public List<ClassRoom> GetClassRooms()
        {
            return context.ClassRooms.Include(b => b.Student).ToList();
        }
        public ClassRoom GetClassRoomById(int classRoomId)
        {
            return context.ClassRooms.Include(b => b.Student).FirstOrDefault(t => t.ClassId == classRoomId);
        }
    }
}
