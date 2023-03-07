using Exspectans.Data;
using Exspectans.DependencyInjection;
using UnityEngine;

namespace Exspectans.Level
{
    public class LevelRenderer : MonoBehaviour
    {
        private TileManager _tileManager;
        private Tile[,] _tiles;

        void Start()
        {
            _tileManager = DependenciesContext.Dependencies.Get<TileManager>();
        }

        public Tile[,] Render(LevelData level)
        {
            _tiles = new Tile[level.Width, level.Height];
            for (int x = 0; x < level.Width; x++)
            {
                for (int y = 0; y < level.Height; y++)
                {
                    _tiles[x, y] = GreateTileGO(x, y, level);
                }
            }
            return _tiles;
        }

        private Tile GreateTileGO(int x, int y, LevelData level)
        {
            // Greate GameObject, set name and add components
            var tileGO = new GameObject($"Tile {x}-{y}");
            var spriteRenderer = tileGO.AddComponent<SpriteRenderer>();
            var tile = tileGO.AddComponent<Tile>();

            // Set tile data
            tile.Data = level.Tiles[x, y];

            // Get sprite for tile
            spriteRenderer.sprite = _tileManager.GetSprite(tile.Data.Name);

            // Cluster all the tiles under the Transform of this script
            tileGO.transform.SetParent(transform);

            // Set position in world
            tileGO.transform.position = new Vector3(x, y, 0);

            return tile;
        }
    }
}