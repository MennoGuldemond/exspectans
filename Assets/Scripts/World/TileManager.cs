using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Exspectans.World
{
    public class TileManager : MonoBehaviour
    {
        private List<TileScriptableObject> _tiles = new();

        void Awake()
        {
            _tiles = Resources.LoadAll<TileScriptableObject>("ScriptableObjects/Tiles").ToList();
        }

        public List<TileScriptableObject> GetAll()
        {
            return _tiles;
        }

        public Sprite GetSprite(string tileName)
        {
            return _tiles.Find(x => x.Name == tileName).Sprite;
        }
    }
}