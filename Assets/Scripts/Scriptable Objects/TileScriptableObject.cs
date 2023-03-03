using UnityEngine;

[CreateAssetMenu(fileName = "New Tile", menuName = "World Tile")]
public class TileScriptableObject : ScriptableObject
{
    public Sprite Sprite;
    public string Name;
    public int MoveCost;
}
