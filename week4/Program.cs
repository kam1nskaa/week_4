using week4;

public class Program
{
	public static void Main()
	{
		University university = new University();

		Course math = new Course(1, "Math", "Supermathematic");
		Course history = new Course(2, "History", "Litopisec");

		university.AddCourse(math);
		university.AddCourse(history);

		Student student1 = new Student(1, "Mariyka");
		Student student2 = new Student(2, "Sashko");

		university.AddStudent(student1);
		university.AddStudent(student2);

		university.EnrollStudent(1, 1);
		university.EnrollStudent(1, 2);
		university.EnrollStudent(2, 2);

		university.AddStudentQueue(student1);
		university.EnrollFromQueue(history);

		university.ShowHistory();

		Console.WriteLine($"{student1.Name} courses:");
		foreach (var course in student1.EnrolledCourse)
		{
			Console.WriteLine(course.GetInfo());
		}

		Console.WriteLine();

		Console.WriteLine($"{student2.Name} courses:");
		foreach (var course in student2.EnrolledCourse)
		{
			Console.WriteLine(course.GetInfo());
		}

	}
}
	
