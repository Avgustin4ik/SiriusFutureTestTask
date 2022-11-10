using Core.Configs;
using Entitas;

namespace Core.UserData
{
    public sealed class UserDataInitializeSystem : IInitializeSystem
    {
        private readonly GameContext _gameContext;
        private readonly GameConfig _gameConfig;

        public UserDataInitializeSystem(GameContext gameContext)
        {
            _gameContext = gameContext;
            _gameContext.isUserData = true;
            _gameConfig = ConfigsCatalogsManager.GetConfig<GameConfig>();
        }
        
        public void Initialize()
        {
            var userDataEntity = _gameContext.userDataEntity;
            userDataEntity.AddDataKey(GameConfig.PlayerDataKey);
            // money and score
            userDataEntity.AddUserDataMoney(0); // savable
            // game levels
            userDataEntity.AddUserDataGameLevel(0); // savable
            userDataEntity.AddPlayerTryCount(_gameConfig.PlayerTryCount);

        }
    }
}