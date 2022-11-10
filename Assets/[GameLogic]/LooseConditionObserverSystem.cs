using System.Collections.Generic;
using Entitas;

public class LooseConditionObserverSystem : ReactiveSystem<GameEntity>
{
    public LooseConditionObserverSystem(GameContext gameContext, UiContext uiContext) : base(gameContext)
    {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.PlayerTryCount);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.playerTryCount.value < 0;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        Contexts.sharedInstance.state.appStateEntity.transitionDefeat = true;
        // throw new System.NotImplementedException("END GAME LOGIC");
    }
}