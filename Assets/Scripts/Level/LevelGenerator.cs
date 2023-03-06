using Exspectans.Data;
using Exspectans.DependencyInjection;
using UnityEngine;

namespace Exspectans.Level
{
    public class LevelGenerator : MonoBehaviour
    {
        private TileManager _tileManager;

        void Start()
        {
            _tileManager = DependenciesContext.Dependencies.Get<TileManager>();
        }

        public LevelData Generate(int width, int height)
        {
            var level = new LevelData(width, height);
            var tileScriptableObjects = _tileManager.GetAll();

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    var randomTile = tileScriptableObjects[Random.Range(0, tileScriptableObjects.Count)];
                    level.Tiles[x, y] = new TileData(x, y, randomTile);
                }
            }
            return level;
        }
    }
}