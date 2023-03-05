using Exspectans.Data;
using Exspectans.DependencyInjection;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Exspectans.World
{
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

        public Data.TileData GetTileData(int x, int y)
        {
            if (x >= 0 && x < WorldData.Width && y >= 0 && y < WorldData.Height)
            {
                return WorldData.Tiles[x, y];
            }
            return null;
        }
    }
}