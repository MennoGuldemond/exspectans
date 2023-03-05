using Exspectans.DependencyInjection;
using Exspectans.World;
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
        private WorldGenerator _worldGenerator;
        [SerializeField]
        private WorldRenderer _worldRenderer;

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);

            DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(TileManager), Factory = () => _tileManager, IsSingleton = true });
            DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(GameManager), Factory = () => _gameManager, IsSingleton = true });
            DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(WorldGenerator), Factory = () => _worldGenerator, IsSingleton = true });
            DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(WorldRenderer), Factory = () => _worldRenderer, IsSingleton = true });
        }
    }
}