using System.Collections.Generic;
using Entitas;

namespace Core.ApplicationStates
{
    public sealed class DefeatTransitionListenerSystem : ReactiveSystem<StateEntity>
    {
        private readonly GameContext _gameContext;

        public DefeatTransitionListenerSystem(StateContext stateContext, GameContext gameContext) : base(stateContext)
        {
            _gameContext = gameContext;
        }

        protected override ICollector<StateEntity> GetTrigger(IContext<StateEntity> context)
        {
            return context.CreateCollector(StateMatcher.Defeat);
        }

        protected override bool Filter(StateEntity entity)
        {
            return true;
        }

        protected override void Execute(List<StateEntity> entities)
        {
            _gameContext.currentGameEntity.isGameStarted = false;
        }
    }
}