using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSchool.Domain
{
    public class Student :Entity, IAggregateRoot
    {
        public  string Name { get; protected set; }
        public  string Email { get; protected set; }
        public StudentCode StudentCode { get; protected set; }
       
     
        private readonly List<Enrollment> enrollments ;
        public IEnumerable<Enrollment> Enrollments => enrollments.AsReadOnly();
        private readonly List<Disenrollment> disenrollments;
        public IEnumerable<Disenrollment> Disenrollments => disenrollments.AsReadOnly();
      

        protected Student()
        {
            enrollments = new List<Enrollment>();
            disenrollments = new List<Disenrollment>();
        }

        public Student(string name, string email,string code)
            : this()
        {
            Name = name;
            Email = email;
            StudentCode = new StudentCode(code);
        }

        public void UpdateInfo(string name, string email)
           
        {
            Name = name;
            Email = email;
        
        }


        public Enrollment GetEnrollment(int index)
        {
            if (enrollments.Count > index)
                return enrollments[index];

            return null;
        }
       

        public void Disenroll(Enrollment enrollment, string comment)
        {
            enrollments.Remove(enrollment);

            var disenrollment = new Disenrollment(enrollment.Student, enrollment.Course, comment);
            disenrollments.Add(disenrollment);
        }

        public void Enroll(Course course)
        {
            if (enrollments.Count >= 3)
                throw new Exception("Cannot have more than 3 enrollments");

            var enrollment = new Enrollment(this, course);
            enrollments.Add(enrollment);
        }

      

    }
}
