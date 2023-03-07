using Exspectans.Data;
using Exspectans.DependencyInjection;
using UnityEngine;

namespace Exspectans.Level
{
    public class LevelManager : MonoBehaviour
    {
        public LevelData LevelData { get; private set; }
        public Tile[,] Tiles { get; private set; }

        private LevelGenerator _levelGenerator;
        private LevelRenderer _levelRenderer;

        void Start()
        {
            _levelGenerator = DependenciesContext.Dependencies.Get<LevelGenerator>();
            _levelRenderer = DependenciesContext.Dependencies.Get<LevelRenderer>();
        }

        public void Create(int width, int height)
        {
            LevelData = _levelGenerator.Generate(width, height);
            Tiles = _levelRenderer.Render(LevelData);
        }

        public TileData GetTileData(int x, int y)
        {
            if (x >= 0 && x < LevelData.Width && y >= 0 && y < LevelData.Height)
            {
                return Tiles[x, y].Data;
            }
            return null;
        }
    }
}