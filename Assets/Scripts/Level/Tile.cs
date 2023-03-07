using Exspectans.Data;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public TileData Data { get; set; }

    private SpriteRenderer _spriteRenderer;
    private Color _mouseOverColor = new Color(255, 255, 255, .9f);

    void Start()
    {
        // Add BoxCollider to make mouse over work
        gameObject.AddComponent<BoxCollider2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnMouseOver()
    {
        _spriteRenderer.color = _mouseOverColor;
    }

    void OnMouseExit()
    {
        _spriteRenderer.color = Color.white;
    }
}
