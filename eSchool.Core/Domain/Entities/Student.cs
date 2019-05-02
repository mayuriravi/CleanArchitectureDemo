using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSchool.Core.Domain
{
    public class Student :Entity
    {
        public  string Name { get; set; }
        public  string Email { get; set; }

        private readonly IList<Enrollment> enrollments = new List<Enrollment>();
        public virtual IReadOnlyList<Enrollment> Enrollments => enrollments.ToList();

        private readonly IList<Disenrollment> disenrollments = new List<Disenrollment>();
        public virtual IReadOnlyList<Disenrollment> Disenrollments => disenrollments.ToList();

        protected Student()
        {
        }

        public Student(string name, string email)
            : this()
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

        public void RemoveEnrollment(Enrollment enrollment, string comment)
        {
            enrollments.Remove(enrollment);

            var disenrollment = new Disenrollment(enrollment.Student, enrollment.Course, comment);
            disenrollments.Add(disenrollment);
        }

        public void Enroll(Course course)
        {
            if (enrollments.Count >= 2)
                throw new Exception("Cannot have more than 2 enrollments");

            var enrollment = new Enrollment(this, course);
            enrollments.Add(enrollment);
        }

    }
}
