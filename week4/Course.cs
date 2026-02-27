namespace week4;

public class Course
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public string Teacher { get; private set; }

    public Course(int id, string name, string teacher)
    {
        Id = id;
        Name = name;
        Teacher = teacher;
    }

    public string GetInfo()
    {
        return $"{Id} {Name} {Teacher}";
    }
}