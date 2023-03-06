using System;
using UnityEngine;

namespace Exspectans.Data
{
    [Serializable]
    public class LevelData
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public TileData[,] Tiles { get; set; }

        public LevelData(int width, int height)
        {
            Width = width;
            Height = height;
            Tiles = new TileData[Width, Height];
        }

        public string ToJson()
        {
            return JsonUtility.ToJson(this);
        }
    }
}