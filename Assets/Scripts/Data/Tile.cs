public class Tile
{
    public int X { get; set; }
    public int Y { get; set; }

    public TileType Type { get; set; }

    public Tile(int xPos, int yPos, TileType type)
    {
        X = xPos;
        Y = yPos;
        Type = type;
    }
}
