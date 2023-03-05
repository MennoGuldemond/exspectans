using UnityEngine;

public class GameDependenciesContext : MonoBehaviour
{
    [SerializeField]
    private GameManager _gameManager;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(GameManager), Factory = () => _gameManager, IsSingleton = true });
    }
}
