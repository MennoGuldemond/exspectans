using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    private PlayerControls _controls;
    private Rigidbody2D _rigidBody;

    [field: SerializeField]
    public float Speed { get; set; }

    void Awake()
    {
        _controls = new PlayerControls();
        _rigidBody = GetComponent<Rigidbody2D>();

        // This is a test for dependency injection
        var gameManager = DependenciesContext.Dependencies.Get<GameManager>();
        if (gameManager != null)
        {
            Debug.Log("Game manager found!");
        }
    }

    private void OnEnable()
    {
        _controls.Player.Move.Enable();
    }

    private void OnDisable()
    {
        _controls.Player.Move.Disable();
    }

    public void OnMove(InputValue input)
    {
        var direction = input.Get<Vector2>();
        _rigidBody.velocity = direction * Speed;
    }
}
