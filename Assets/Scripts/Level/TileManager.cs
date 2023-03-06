using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Exspectans.Level
{
    public class TileManager : MonoBehaviour
    {
        private List<TileSO> _tiles = new();

        void Awake()
        {
            _tiles = Resources.LoadAll<TileSO>("ScriptableObjects/Tiles").ToList();
        }

        public List<TileSO> GetAll()
        {
            return _tiles;
        }

        public TileSO Get(string tileName)
        {
            return _tiles.Find(x => x.Name == tileName);
        }

        public Sprite GetSprite(string tileName)
        {
            return _tiles.Find(x => x.Name == tileName).Sprite;
        }
    }
}