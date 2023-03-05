using Exspectans.DependencyInjection;
using Exspectans.World;
using UnityEngine;

namespace Exspectans
{
    public class GameManager : MonoBehaviour
    {
        public int WorldWidth = 10;
        public int WorldHeight = 10;
        public GameObject Outline;

        private WorldManager _worldmanager;

        private Vector3Int previousMousePos = new();

        void Start()
        {
            _worldmanager = DependenciesContext.Dependencies.Get<WorldManager>();
            _worldmanager.Create(WorldWidth, WorldHeight);
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
            var tile = _worldmanager.Tilemap.GetTile(mousePos);

            if (tile)
            {
                Debug.Log($"Tile found at {mousePos}");
            }
        }

        private Vector3Int GetMousePosition()
        {
            Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            return _worldmanager.Tilemap.WorldToCell(mouseWorldPos);
        }
    }
}