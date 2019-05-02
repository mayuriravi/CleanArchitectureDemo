namespace eSchool.Domain
{
    public class Enrollment :Entity
    {      
       
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

        internal void Update(Course course)
        {
            this.Course = course;
        }
    }
    
}
