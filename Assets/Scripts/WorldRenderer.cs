using Exspectans.Data;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Exspectans
{
    [RequireComponent(typeof(Grid))]
    public class WorldRenderer : MonoBehaviour
    {
        [SerializeField]
        public List<TileScriptableObject> tileScriptableObjects = new();

        private Tilemap _tilemap;

        void Start()
        {
            _tilemap = GetComponentInChildren<Tilemap>();
        }

        public Tilemap Render(World world, int width, int height)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    var tile = ScriptableObject.CreateInstance<UnityEngine.Tilemaps.Tile>();
                    var tileData = world.Tiles[x, y];
                    tile.sprite = tileScriptableObjects.Find(x => x.name == tileData.Type.Name).Sprite;
                    _tilemap.SetTile(new Vector3Int(x, y, 0), tile);
                }
            }
            return _tilemap;
        }
    }
}