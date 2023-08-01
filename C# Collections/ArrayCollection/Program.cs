namespace ArrayCollection;

public class Program
{
    public static void Main(string[] args)
    {
        // int[] lockCombination = new int[3];
        // lockCombination = new int[] {10, 5, 32};

        // int last = lockCombination[2];
        // Console.WriteLine(last);

        // Cell[][] sheet = new Cell[100][];
        // sheet[0] = new Cell[10];
        // sheet[0][0]  = new Cell();
        
        // Console.WriteLine(sheet[0][0]);

        int size = 5;

        List<int> myList = new List<int>();

        for (int i = 0; i < size; i++)
        {
            myList.Add((int) System.Math.Pow(2, i));
        }

        foreach (int i in myList)
        {
            Console.WriteLine(i);
        }
    }
}
