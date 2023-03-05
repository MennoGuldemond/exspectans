using UnityEngine;

public class GameDependenciesContext : MonoBehaviour
{
    [SerializeField]
    private GameManager GameManager;

    private void Awake()
    {
        DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(GameManager), Factory = () => GameManager, IsSingleton = true });
    }
}
