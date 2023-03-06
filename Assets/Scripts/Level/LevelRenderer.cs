using Exspectans.Data;
using Exspectans.DependencyInjection;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Exspectans.Level
{
    [RequireComponent(typeof(Grid))]
    public class LevelRenderer : MonoBehaviour
    {
        private Tilemap _tilemap;
        private TileManager _tileManager;

        void Start()
        {
            _tilemap = GetComponentInChildren<Tilemap>();
            _tileManager = DependenciesContext.Dependencies.Get<TileManager>();
        }

        public Tilemap Render(LevelData level)
        {
            for (int x = 0; x < level.Width; x++)
            {
                for (int y = 0; y < level.Height; y++)
                {
                    var tile = ScriptableObject.CreateInstance<Tile>();
                    var tileData = level.Tiles[x, y];
                    tile.sprite = _tileManager.GetSprite(tileData.Name);
                    _tilemap.SetTile(new Vector3Int(x, y, 0), tile);
                }
            }
            return _tilemap;
        }
    }
}