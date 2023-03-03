using Game.Data;
using UnityEngine;

public class WorldGenerator
{
    public World Generate(int width, int height)
    {
        var world = new World(width, height);

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                TileType tileType;
                var random = Random.Range(0, 3);
                switch (random)
                {
                    case 0: 
                        tileType =new TileType("Stone", 1);
                        break;
                    case 1:
                        tileType = new TileType("Sand", 1);
                        break;
                    case 2:
                        tileType = new TileType("Dirt", 1);
                        break;
                    default:
                        tileType = new TileType("Stone", 1);
                        break;
                }
                world.Tiles[x, y] = new Tile(x, y, tileType);
            }
        }

        return world;
    }
}

