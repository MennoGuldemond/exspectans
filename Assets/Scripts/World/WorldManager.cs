using Exspectans.Data;
using Exspectans.DependencyInjection;
using Exspectans.World;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WorldManager : MonoBehaviour
{
    public WorldData WorldData { get; private set; }
    public Tilemap Tilemap { get; private set; }

    private WorldGenerator _worldGenerator;
    private WorldRenderer _worldRenderer;

    void Start()
    {
        _worldGenerator = DependenciesContext.Dependencies.Get<WorldGenerator>();
        _worldRenderer = DependenciesContext.Dependencies.Get<WorldRenderer>();
    }

    public Tilemap Create(int width, int height)
    {
        WorldData = _worldGenerator.Generate(width, height);
        Tilemap = _worldRenderer.Render(WorldData);
        return Tilemap;
    }
}
