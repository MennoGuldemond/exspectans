using UnityEngine;

[CreateAssetMenu(fileName = "New Tile", menuName = "Custom/World Tile")]
public class TileSO : ScriptableObject
{
    public Sprite Sprite;
    public string Name;
    public int MoveCost;
}