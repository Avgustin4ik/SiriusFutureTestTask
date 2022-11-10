using Core.Configs;
using Core.Extension;
using Entitas;

namespace Core.GameLevels
{
    public class LevelSchema : MonoBehAdvGameLevelCleanup
    {
        private GameConfig _gameConfig;

        public string GameObjectName
        {
            get => gameObject.name;
            set => gameObject.name = value;
        }

        public override void Init(IEntity iEntity)
        {
            base.Init(iEntity);
            GameEntity.isLevel = true;
            
            _gameConfig = ConfigsCatalogsManager.GetConfig<GameConfig>();

        }

    }
}