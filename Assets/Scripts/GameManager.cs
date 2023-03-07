using Exspectans.DependencyInjection;
using Exspectans.Level;
using UnityEngine;

namespace Exspectans
{
    public class GameManager : MonoBehaviour
    {
        public int WorldWidth = 10;
        public int WorldHeight = 10;
        public GameObject Outline;

        private LevelManager _levelmanager;

        void Start()
        {
            _levelmanager = DependenciesContext.Dependencies.Get<LevelManager>();
            _levelmanager.Create(WorldWidth, WorldHeight);
        }

        public void OnPrimary()
        {
            var mousePos = GetMousePosition();
            var tile = _levelmanager.GetTileData(mousePos.x, mousePos.y);
            if (tile != null)
            {
                Debug.Log($"{tile.Name} located at {mousePos}");
            }
        }

        private Vector3Int GetMousePosition()
        {
            Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            return new Vector3Int((int)Mathf.Round(mouseWorldPos.x), (int)Mathf.Round(mouseWorldPos.y), 0);
        }
    }
}