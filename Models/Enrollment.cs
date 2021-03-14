namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        //tinfo200:[2021-03-13-hn98-dykstra1] -Created the Enrollment entity for the data model.The EnrollmentID property is the primary key. 
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }
    }
}