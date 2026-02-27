namespace week4;

public class Student
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public List<Course> EnrolledCourse { get; private set; }
    
    public Student(int id, string name)
    {
        Id = id;
        Name = name;
        EnrolledCourse = new List<Course>();
    }
    public void EnrollStudent(Course course)
    {
        EnrolledCourse.Add(course);
    }
}