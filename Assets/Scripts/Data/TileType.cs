namespace Game.Data
{
    public class TileType
    {
        public string Name { get; set; }
        public int MoveCost { get; set; }

        public TileType(string name, int moveCost)
        {
            Name = name;
            MoveCost = moveCost;
        }
    }
}