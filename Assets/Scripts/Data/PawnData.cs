using System.Collections.Generic;

namespace Exspectans.Data
{
    public class PawnData
    {
        public string Name { get; set; }
        public float HitPoints { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Credits { get; set; }
        public List<ItemData> Items { get; set; }   

        public PawnData()
        {
            Items = new List<ItemData>();
        }
    }
}