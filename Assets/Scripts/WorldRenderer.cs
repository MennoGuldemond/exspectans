using Game.Data;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(Grid))]
public class WorldRenderer : MonoBehaviour
{
    [SerializeField]
    public List<TileScriptableObject> tileScriptableObjects = new List<TileScriptableObject>();

    public int Width= 5;
    public int Height = 5;

    private TilemapRenderer _tilemapRenderer;
    private Tilemap _tilemap;

    void Start()
    {
        _tilemapRenderer = GetComponentInChildren<TilemapRenderer>();
        _tilemap = GetComponentInChildren<Tilemap>();

        var worldGenerator = new WorldGenerator();
        var world = worldGenerator.Generate(Width, Height);
        Render(world);
    }

    void Render(World world)
    {
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                var tile = new UnityEngine.Tilemaps.Tile();
                var tileData = world.Tiles[x, y];
                tile.sprite = tileScriptableObjects.Find(x => x.name == tileData.Type.Name).Sprite;
                _tilemap.SetTile(new Vector3Int(x, y, 0), tile);
            }
        }
        
    }
}
