using System.Collections.Generic;
using Entitas;

public class RemovePlayerTryCountSystem : ReactiveSystem<GameEntity>
{
    private readonly IGroup<UiEntity> _uiLiveCounterGroup;

    public RemovePlayerTryCountSystem(GameContext gameContext, UiContext uiContext) : base(gameContext)
    {
        _uiLiveCounterGroup = uiContext.GetGroup(UiMatcher.PlayerTryCounter);
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.LetterBoxFail);
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        var userData = Contexts.sharedInstance.game.userDataEntity;
        foreach (var requestEntity in entities)
        {
            userData.ReplacePlayerTryCount(userData.playerTryCount.value - 1);
            foreach (var uiEntity in _uiLiveCounterGroup.GetEntities())
            {
                uiEntity.ReplaceUIPlayerTryCount(userData.playerTryCount.value);
            }
            requestEntity.Destroy();
        }
    }
}