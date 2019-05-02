using System;

namespace eSchool.Core.Domain
{
    public class Disenrollment 
    {
        public Student Student { get; protected set; }
        public  Course Course { get; protected set; }
        public  DateTime DateTime { get; protected set; }
        public  string Comment { get; protected set; }

        protected Disenrollment()
        {
        }

        public Disenrollment(Student student, Course course, string comment)
            : this()
        {
            Student = student;
            Course = course;
            Comment = comment;
            DateTime = DateTime.UtcNow;
        }
    }
}
