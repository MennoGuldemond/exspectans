using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    [field:SerializeField]
    public int Width { get; set; }
    [field:SerializeField]
    public int Height { get; set; }


    public void Start()
    {
        Generate();
    }

    public World Generate()
    {
        var world = new World(Width, Height);

        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                var tileType = new TileType("Stone", 1);
                world.Tiles[x, y] = new Tile(x, y, tileType);
            }
        }

        return world;
    }
}

