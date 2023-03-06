namespace Exspectans.Data
{
    public enum MissionGoalType
    {
        KillTarget,
        KillAll,
        GetItem,
        SurviveTurns,
        ReachPosition
    }

    public class MissionData
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int RewardExperience { get; set; }
        public int RewardCredits { get; set; }
        public MissionGoalType GoalType { get; set; }

        public MissionData(string title, string description, int rewardExperience, int rewardCredits)
        {
            Title = title;
            Description = description;
            RewardExperience = rewardExperience;
            RewardCredits = rewardCredits;
        }
    }
}