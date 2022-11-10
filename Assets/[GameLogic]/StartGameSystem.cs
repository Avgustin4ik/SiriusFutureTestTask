using System.Collections.Generic;
using Entitas;

public class StartGameSystem : ReactiveSystem<GameEntity>
{
    private readonly StateContext _stateContext;

    public StartGameSystem(GameContext gameContext, UiContext uiContext) : base(gameContext)
    {
        _stateContext = Contexts.sharedInstance.state;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.UserDataGameLevel.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.userDataGameLevel.value == 0;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var userData in entities)
        {
            _stateContext.appStateEntity.transitionMainMenu = true;
        }
    }
}