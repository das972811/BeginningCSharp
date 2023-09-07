namespace ArrayCollection;

public class Student : IComparable<Student>
{
    public string Name { get; set; } = null!;
    public int GradeLevel {get; set; }

    public int CompareTo(Student? that)
    {
        int result = Name.CompareTo(that?.Name);

        if (result == 0)
        {
            result = GradeLevel.CompareTo(that?.GradeLevel);
        }

        return result;
    }
}