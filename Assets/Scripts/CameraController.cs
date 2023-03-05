using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    private PlayerControls _controls;
    private Rigidbody2D _rigidBody;

    [field: SerializeField]
    public float Speed { get; set; }

    void Start()
    {
        _controls = new PlayerControls();
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue input)
    {
        var direction = input.Get<Vector2>();
        _rigidBody.velocity = direction * Speed;
    }
}