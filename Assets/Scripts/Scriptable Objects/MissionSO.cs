using UnityEngine;

[CreateAssetMenu(fileName = "New Mission", menuName = "Custom/Mission")]
public class MissionSO : ScriptableObject
{
    public string Title;
    public string Description;
    public int RewardExperience;
    public int RewardCredits;
}