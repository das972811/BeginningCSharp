﻿using System.Text;
using System.Net;
using Newtonsoft.Json;

namespace SoccerStats;

class Program
{
    static void Main(string[] args)
    {
        // string currentDirectory =  Directory.GetCurrentDirectory();
        // DirectoryInfo directory = new DirectoryInfo(currentDirectory);
        // var fileName = Path.Combine(directory.FullName, "SoccerGameResults.csv");
        // var fileContents = ReadSoccerResults(fileName);

        // fileName = Path.Combine(directory.FullName, "players.json");

        // var players = DeserializePlayers(fileName);
        // var topTenPlayers = GetTopTenPlayers(players);

        // foreach (var player in topTenPlayers)
        // {
        //     Console.WriteLine("Name: " + player.FirstName + " PPG: " + player.PointsPerGame);
        // }

        // fileName = Path.Combine(directory.FullName, "topTen.json");
        // SerializePlayersToFile(topTenPlayers, fileName);

        Console.WriteLine(GetGoolgeHomePage());

        // Console.WriteLine(fileContents);
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

                soccerResult.Add(gameResult);
            }
        }

        return soccerResult;
    }

    public static List<Player> DeserializePlayers(string fileName)
    {
        var players = new List<Player>();
        var serializer = new JsonSerializer();

        using(var reader = new StreamReader(fileName))
        using(var jsonReader = new JsonTextReader(reader))
        {
            players = serializer.Deserialize<List<Player>>(jsonReader);
        }

        return players;
    }

    public static List<Player> GetTopTenPlayers(List<Player> players)
    {
        var topTenPlayers = new List<Player>();
        players.Sort(new PlayerComparer());
        int counter = 0;

        foreach(var player in players)
        {
            topTenPlayers.Add(player);
            counter++;

            if (counter == 10)
            {
                break;
            }
        }

        return topTenPlayers;
    }

    public static void SerializePlayersToFile(List<Player> players, string fileName)
    {
        var serializer = new JsonSerializer();
        
        using (var writer = new StreamWriter(fileName))
        using (var jsonWriter = new JsonTextWriter(writer))
        {
            serializer.Serialize(jsonWriter, players);
        }
    }

    public static string GetGoolgeHomePage()
    {
        var webClient = new WebClient();

        byte[] googleHome = webClient.DownloadData("https://www.google.com");
        // Stream stream = new Stream();

        using (var stream = new MemoryStream(googleHome))
        using (var reader = new StreamReader(stream))
        {
            return reader.ReadToEnd();
        }
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