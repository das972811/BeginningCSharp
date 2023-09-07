namespace ArrayCollection;

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new() {
            new Student() { Name = "Sally", GradeLevel = 3},
            new Student() { Name = "Bob", GradeLevel = 3},
            new Student() { Name = "Sally", GradeLevel = 2}
        };

        students.Sort();

        Student newStudent = new() { Name = "Joe", GradeLevel = 2 };

        int index = students.BinarySearch(newStudent);

        if (index < 0)
        {
            // Bitwise compliment
            // ~index
            students.Insert((-index) - 1, newStudent);
        }

        foreach(Student student in students)
        {
            Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
        }
    }

    public void GenerateSheetWithMultiDimensionalArrays()
    {
        Cell[,] sheets = new Cell[2, 2];

        for (int rowIndex = 0; rowIndex < sheets.GetLength(0); rowIndex++)
        {
            for (int colIndex = 0; colIndex < sheets.GetLength(1); colIndex++)
            {
                sheets[rowIndex, colIndex] = new() { Contents = "Diego" };
            }
        }

        Console.WriteLine(sheets[0, 0].Contents);
    }

    public void GenerateNewCellsWithJaggedArray()
    {
        Cell[][] sheet = new Cell[2][];
        sheet[0] = new Cell[2] {new() { Contents = "Diego" }, new() { Contents = "Salas" }};
        sheet[1] = new Cell[2] { new() { Contents = "Mom" }, new() { Contents = "Polar" }};

        foreach (Cell[] row in sheet)
        {
            foreach (Cell cell in row)
            {
                Console.Write(cell.Contents);
            }

            Console.WriteLine("");
        }
    }
}
