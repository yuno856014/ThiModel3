using Microsoft.EntityFrameworkCore;
using StudentMagament.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMagament.DBContextts
{
    public class StudentMagamentDBContext : DbContext
    {
        public StudentMagamentDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedingClassRoom(modelBuilder);
            SeedingStudent(modelBuilder);
        }
        private void SeedingClassRoom(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassRoom>().HasData(
               new ClassRoom()
               {
                   ClassId = 1,
                   ClassName = "Toan Hoc"
               }, new ClassRoom()
               {
                   ClassId = 2,
                   ClassName = "Sinh Hoc"
               });
        }
        private void SeedingStudent(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    StudentId = 1,
                    ClassId = 2,
                    StudentName = "Duy Tran",
                    DateOfBirth = 2000,
                    Email = "duy.tran@gmail.com",
                    Gender = true
                }, new Student()
                {
                    StudentId = 2,
                    ClassId = 1,
                    StudentName = "Thanh Ho",
                    DateOfBirth = 1999,
                    Email = "thanh.ho@gmail.com",
                    Gender = true
                }
                );
        }
    }
}
