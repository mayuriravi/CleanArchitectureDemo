using System;

namespace eSchool.Domain
{
    public class Disenrollment :Entity
    {
        public Student Student { get; protected set; }
        public  Course Course { get; protected set; }
        public  DateTime Timestamp { get; protected set; }
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
            Timestamp = DateTime.UtcNow;
        }
    }
}
