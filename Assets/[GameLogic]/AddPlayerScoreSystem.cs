using System.Collections.Generic;
using Core.Configs;
using Entitas;

public class AddPlayerScoreSystem : ReactiveSystem<GameEntity>
{
    public AddPlayerScoreSystem(GameContext gameContext, UiContext uiContext) : base(gameContext)
    {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.LetterBoxOpen.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        var gameConfig = ConfigsCatalogsManager.GetConfig<GameConfig>();
        var userData = Contexts.sharedInstance.game.userDataEntity;
        foreach (var request in entities)
        {
            userData.ReplaceUserDataMoney(userData.userDataMoney.value + gameConfig.ScoreIncreaseDelta);
            request.Destroy();
        }
    }
}