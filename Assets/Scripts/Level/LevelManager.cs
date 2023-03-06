using Exspectans.Data;
using Exspectans.DependencyInjection;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Exspectans.Level
{
    public class LevelManager : MonoBehaviour
    {
        public LevelData LevelData { get; private set; }
        public Tilemap Tilemap { get; private set; }

        private LevelGenerator _levelGenerator;
        private LevelRenderer _levelRenderer;

        void Start()
        {
            _levelGenerator = DependenciesContext.Dependencies.Get<LevelGenerator>();
            _levelRenderer = DependenciesContext.Dependencies.Get<LevelRenderer>();
        }

        public Tilemap Create(int width, int height)
        {
            LevelData = _levelGenerator.Generate(width, height);
            Tilemap = _levelRenderer.Render(LevelData);
            return Tilemap;
        }

        public Data.TileData GetTileData(int x, int y)
        {
            if (x >= 0 && x < LevelData.Width && y >= 0 && y < LevelData.Height)
            {
                return LevelData.Tiles[x, y];
            }
            return null;
        }
    }
}