using System.Text;

namespace SoccerStats;

class Program
{
    static void Main(string[] args)
    {
        string currentDirectory =  Directory.GetCurrentDirectory();
        DirectoryInfo directory = new DirectoryInfo(currentDirectory);
        var fileName = Path.Combine(directory.FullName, "SoccerGameResults.csv");
        var fileContents = ReadSoccerResults(fileName);

        Console.WriteLine(fileContents);
    }

    public static string ReadFile(string fileName)
    {
        using (var reader = new StreamReader(fileName))
        {
            return reader.ReadToEnd();
        }
    }
    public static List<string[]> ReadSoccerResults(string fileName)
    {
        var soccerResult = new List<string[]>();

        using (var reader = new StreamReader(fileName))
        {
            string line = "";
            while((line = reader.ReadLine()) != null)
            {
                string[] values = line.Split(',');
                soccerResult.Add(values);
            }
        }

        return soccerResult;
    }
}

// var fileContents = ReadFile(fileName);
// string[] fileLines = fileContents.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

// foreach (var line in fileLines)
// {
//     Console.WriteLine(line);
// }

// char capitalH = 'H';
// char lowerH = '\u0068';

// Console.WriteLine(capitalH);
// byte[] unicodeBytes = UnicodeEncoding.Unicode.GetBytes(new char[] {lowerH});
// string unicodeString = UnicodeEncoding.Unicode.GetString(unicodeBytes);

// Console.WriteLine(unicodeBytes);
// Console.WriteLine(unicodeString);

// byte[] mysteryMessage = {89,0,97,0,121,0,33,0}; 
// string message = UnicodeEncoding.Unicode.GetString(mysteryMessage);
// Console.WriteLine(message);

// sbyte signedByte = -128;

// char degree = '\u00B0';
// Console.WriteLine("The current temperature is 74.6" + degree + "F");