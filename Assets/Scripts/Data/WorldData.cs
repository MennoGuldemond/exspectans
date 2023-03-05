namespace Exspectans.Data
{
    public class WorldData
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public TileData[,] Tiles { get; set; }

        public WorldData(int width, int height)
        {
            Width = width;
            Height = height;
            Tiles = new TileData[Width, Height];
        }
    }
}