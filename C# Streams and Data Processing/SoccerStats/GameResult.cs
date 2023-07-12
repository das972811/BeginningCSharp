namespace SoccerStats;

public class GameResult
{
    public DateTime GameDate { get; set; }
    public string TeamName { get; set; }
    public HomeOrAway HomeOrAway { get; set; }
    public int Goals { get; set; }
    public int GoalAttempt { get; set; }
    public int ShotsOnGoal { get; set; }
    public int ShotsOfGoal { get; set; }
    public double PossessionPercent { get; set; }
    public double ConversionRate {
        get {
            return (double) Goals / (double) GoalAttempt;
        }
    }
}

public enum HomeOrAway
{
    Home,
    Away
}