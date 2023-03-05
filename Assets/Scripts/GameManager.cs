using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(WorldRenderer))]
public class GameManager : MonoBehaviour
{
    public int WorldWidth = 10;
    public int WorldHeight = 10;

    private WorldRenderer _worldRenderer;
    private Tilemap _tilemap;

    void Start()
    {
        _worldRenderer = GetComponent<WorldRenderer>();

        var worldGenerator = new WorldGenerator();
        var world = worldGenerator.Generate(WorldWidth, WorldHeight);

        _tilemap = _worldRenderer.Render(world, WorldWidth, WorldHeight);
    }

    public void OnPrimary()
    {
        Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        var tilePos = _tilemap.WorldToCell(worldPoint);
        var tile = _tilemap.GetTile(tilePos);

        if (tile)
        {
            Debug.Log($"Tile found at {tilePos}");
        }
    }
}
