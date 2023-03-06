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

        private Vector3Int previousMousePos = new();

        void Start()
        {
            _levelmanager = DependenciesContext.Dependencies.Get<LevelManager>();
            _levelmanager.Create(WorldWidth, WorldHeight);
        }

        private void Update()
        {
            var mousePos = GetMousePosition();
            if (!mousePos.Equals(previousMousePos))
            {
                Outline.transform.position = new Vector3(mousePos.x + .5f, mousePos.y + .5f, 0);
                previousMousePos = mousePos;
            }
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
            return _levelmanager.Tilemap.WorldToCell(mouseWorldPos);
        }
    }
}