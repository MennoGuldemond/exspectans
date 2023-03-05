namespace Exspectans.Data
{
    public class TileData
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }
        public int MoveCost { get; set; }

        public TileData(int xPos, int yPos, string name, int moveCost)
        {
            X = xPos;
            Y = yPos;
            Name = name;
            MoveCost = moveCost;
        }

        public TileData(int xPos, int yPos, TileScriptableObject tileSO)
        {
            X = xPos;
            Y = yPos;
            Name = tileSO.Name;
            MoveCost = tileSO.MoveCost;
        }
    }
}