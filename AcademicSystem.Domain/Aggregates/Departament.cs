using AcademicSystem.Domain.Aggregates.ProfileInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSystem.Domain.Aggregates
{
    public class Departament
    {
        private readonly List<Course> _courses = new List<Course>();
        private readonly List<Teacher> _teachers = new List<Teacher>();


        private Departament() { }

        public Guid DepartamentId { get; private set; }
        public string DepartamentName { get; private set; }



        public IEnumerable<Course> Courses { get { return _courses; } }
        public IEnumerable<Teacher> Teachers { get { return _teachers; } }

        public static Departament CreateDepartament(string departamentName)
        {
            var departament = new Departament 
            { 
                DepartamentName = departamentName,
                DepartamentId = Guid.NewGuid()

            };
            return departament;
        }

        public void UpdateDepartament(string departametName)
        {
            DepartamentName = departametName;
        }

        public void AddCourse(Course courseNew)
        {
            _courses.Add(courseNew);
        }
        public void AddTeacher(Teacher teacherNew)
        {
            _teachers.Add(teacherNew);
        }
        public void UpdateCourse(string nameCourseUpdate, Guid courseId)
        {
            var course = _courses.FirstOrDefault(c => c.CourseId == courseId);
            if (course == null) return;
            
            course.UpdateCourse(nameCourseUpdate);

        }
        public void UpdateTeacher (BasicInfo newInfo, Guid teacherId)
        {
            var teacher = _teachers.FirstOrDefault(t=> t.TeacherId == teacherId);
            teacher.UpdateTeacher(newInfo);
        }
        public void DeleteCourse(Guid courseId)
        {
            var course = _courses.FirstOrDefault(c=>c.CourseId == courseId);
            _courses.Remove(course);
        }
        public void DeleteTeacher(Guid teacherId)
        {
            var teacher = _teachers.FirstOrDefault(t => t.TeacherId == teacherId);
            _teachers.Remove(teacher);
        }
    }
}
