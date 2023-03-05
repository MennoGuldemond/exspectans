using UnityEngine;

[CreateAssetMenu(fileName = "New Tile", menuName = "Custom/World Tile")]
public class TileScriptableObject : ScriptableObject
{
    public Sprite Sprite;
    public string Name;
    public int MoveCost;
}
