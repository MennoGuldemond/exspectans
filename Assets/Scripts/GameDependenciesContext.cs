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
        private LevelManager _worldManager;
        [SerializeField]
        private LevelGenerator _worldGenerator;
        [SerializeField]
        private LevelRenderer _worldRenderer;

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);

            DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(TileManager), Factory = () => _tileManager, IsSingleton = true });
            DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(GameManager), Factory = () => _gameManager, IsSingleton = true });
            DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(LevelManager), Factory = () => _worldManager, IsSingleton = true });
            DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(LevelGenerator), Factory = () => _worldGenerator, IsSingleton = true });
            DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(LevelRenderer), Factory = () => _worldRenderer, IsSingleton = true });
        }
    }
}