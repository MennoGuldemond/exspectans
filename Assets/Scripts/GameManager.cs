using UnityEngine;
using UnityEngine.Tilemaps;

namespace Exspectans
{
    [RequireComponent(typeof(WorldRenderer))]
    public class GameManager : MonoBehaviour
    {
        public int WorldWidth = 10;
        public int WorldHeight = 10;
        public GameObject Outline;

        private WorldRenderer _worldRenderer;
        private Tilemap _tilemap;

        private Vector3Int previousMousePos = new();

        void Start()
        {
            _worldRenderer = GetComponent<WorldRenderer>();

            var worldGenerator = new WorldGenerator();
            var world = worldGenerator.Generate(WorldWidth, WorldHeight);

            _tilemap = _worldRenderer.Render(world, WorldWidth, WorldHeight);
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
            var tile = _tilemap.GetTile(mousePos);

            if (tile)
            {
                Debug.Log($"Tile found at {mousePos}");
            }
        }

        private Vector3Int GetMousePosition()
        {
            Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            return _tilemap.WorldToCell(mouseWorldPos);
        }
    }
}