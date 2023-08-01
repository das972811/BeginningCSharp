namespace ArrayCollection;

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student() { Name = "Diego", GradeLevel = 3 },
            new Student() { Name = "Bob", GradeLevel = 3 },
            new Student() { Name = "Alicia", GradeLevel = 2 }
        };

        students.Sort();

        foreach(Student student in students)
        {
            Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
        }
    }
}
