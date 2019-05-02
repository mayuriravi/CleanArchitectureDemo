namespace eSchool.Core.Domain
{
    public class Enrollment 
    {
        public int EnrollmentId { get; set; }
        public Student Student { get; protected set; }
        public Course Course { get; protected set; }        

        protected Enrollment()
        {
        }

        public Enrollment(Student student, Course course)
            : this()
        {
            Student = student;
            Course = course;            
        }

        public void Update(Course course)
        {
            Course = course;          
        }
    }
    
}
