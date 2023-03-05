namespace Exspectans.Data
{
    public class World
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Tile[,] Tiles { get; set; }

        public World(int width, int height)
        {
            Width = width;
            Height = height;

            Tiles = new Tile[Width, Height];
        }
    }
}