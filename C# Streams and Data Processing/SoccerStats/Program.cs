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
    public static List<GameResult> ReadSoccerResults(string fileName)
    {
        var soccerResult = new List<GameResult>();

        using (var reader = new StreamReader(fileName))
        {
            string line = "";
            reader.ReadLine();
            while((line = reader.ReadLine()) != null)
            {
                var gameResult = new GameResult();
                string[] values = line.Split(',');

                DateTime gameDate;
                if (DateTime.TryParse(values[0], out gameDate))
                {
                    gameResult.GameDate = gameDate;
                }

                gameResult.TeamName = values[1];
                
                HomeOrAway homeOrAway;
                if (Enum.TryParse(values[2], out homeOrAway))
                {
                    gameResult.HomeOrAway = homeOrAway;
                }

                int parseInt;
                if (int.TryParse(values[3], out parseInt))
                {
                    gameResult.Goals = parseInt;
                }

                if (int.TryParse(values[4], out parseInt))
                {
                    gameResult.GoalAttempt = parseInt;
                }

                if (int.TryParse(values[5], out parseInt))
                {
                    gameResult.ShotsOnGoal = parseInt;
                }

                if (int.TryParse(values[5], out parseInt))
                {
                    gameResult.ShotsOfGoal = parseInt;
                }

                double possessionPercent;
                if (double.TryParse(values[6], out possessionPercent))
                {
                    gameResult.PossessionPercent = possessionPercent;
                }

                // gameResult.ConversionRate = (double) gameResult.Goals / gameResult.GoalAttempt;

                soccerResult.Add(gameResult);
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