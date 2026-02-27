namespace week4;

public class University
{
    private static List<Course> allCourses = new();
    private static Dictionary<int, Student> students = new();
    private Queue<Student> studentsQueue = new();
    private Stack<string> changesHistory = new();

    public void AddCourse(Course course)
    {
        allCourses.Add(course);
        Console.WriteLine($"Added {course.Name}");
        changesHistory.Push($"Course added {course.Name}");
    }

    public void AddStudent(Student student)
    {
        students.Add(student.Id, student);
        Console.WriteLine($"Added student {student.Name}");
        changesHistory.Push($"Student {student.Name} added");
    }
    public void EnrollStudent (int studentId, int courseId)
    {
        if (!students.ContainsKey(studentId))
        {
            Console.WriteLine("Student not found");
            return;
        }

        Course course = allCourses.Find(c => c.Id == courseId);

        if (course == null)
        {
            Console.WriteLine("Course not found");
            return;
        }

        students[studentId].EnrollStudent(course);
        changesHistory.Push($"Student {students[studentId].Name} enrolled to {course.Name} course");
    }

    public void AddStudentQueue(Student student)
    {
        studentsQueue.Enqueue(student);
        changesHistory.Push($"Student {student.Name} added to  queue");
    }

    public void ChangesHistory(Student student, Course course)
    {
        student.EnrollStudent(course);
        changesHistory.Push($"Student {student.Name} enrolled to {course.Name}");
    }
    public void EnrollFromQueue(Course course)
    {
        if (studentsQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Student student = studentsQueue.Dequeue();
        student.EnrollStudent(course);
        changesHistory.Push($"Student {student.Name} enrolled to {course.Name}");
    }

    public void ShowHistory()
    {
        foreach (var change in changesHistory)
        {
            Console.WriteLine(change);
        }
    }
}

