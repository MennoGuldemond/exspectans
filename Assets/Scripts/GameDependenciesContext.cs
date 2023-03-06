using Exspectans.DependencyInjection;
using Exspectans.Level;
using UnityEngine;

namespace Exspectans
{
    public class GameDependenciesContext : MonoBehaviour
    {
        [SerializeField]
        private GameManager _gameManager;
        [SerializeField]
        private TileManager _tileManager;
        [SerializeField]
        private LevelManager _levelManager;
        [SerializeField]
        private LevelGenerator _levelGenerator;
        [SerializeField]
        private LevelRenderer _levelRenderer;

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);

            DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(TileManager), Factory = () => _tileManager, IsSingleton = true });
            DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(GameManager), Factory = () => _gameManager, IsSingleton = true });
            DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(LevelManager), Factory = () => _levelManager, IsSingleton = true });
            DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(LevelGenerator), Factory = () => _levelGenerator, IsSingleton = true });
            DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(LevelRenderer), Factory = () => _levelRenderer, IsSingleton = true });
        }
    }
}