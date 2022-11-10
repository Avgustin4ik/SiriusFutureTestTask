using System.Collections.Generic;
using Core.Configs;
using Entitas;

namespace Core.ApplicationStates
{
    public sealed class CompleteLevelTransitionListenerSystem : ReactiveSystem<StateEntity>
    {
        private readonly StateContext _stateContext;
        private readonly IGroup<GameEntity> _quizRulesGroup;
        private readonly int _playerTryCount;

        public CompleteLevelTransitionListenerSystem(StateContext stateContext, LevelContext levelContext) : base(stateContext)
        {
            _stateContext = stateContext;
            _quizRulesGroup = Contexts.sharedInstance.game.GetGroup(GameMatcher.QuizRules);
            _playerTryCount = ConfigsCatalogsManager.GetConfig<GameConfig>().PlayerTryCount;
        }

        protected override ICollector<StateEntity> GetTrigger(IContext<StateEntity> context)
        {
            return context.CreateCollector(StateMatcher.CompleteLevel);
        }

        protected override bool Filter(StateEntity entity)
        {
            return true;
        }

        protected override void Execute(List<StateEntity> entities)
        {
            var userData = Contexts.sharedInstance.game.userDataEntity;
            var nextLevelNumber = userData.userDataGameLevel.value + 1;
            userData.ReplaceUserDataGameLevel(nextLevelNumber);
            userData.ReplacePlayerTryCount(_playerTryCount);
            var score = userData.userDataMoney.value + userData.playerTryCount.value;
            userData.ReplaceUserDataMoney(score);
            //todo reload level
            foreach (var quizEntity in _quizRulesGroup.GetEntities())
            {
                quizEntity.ReplaceRiddleWord(quizEntity.riddleWordsDatabase.value[nextLevelNumber]);
            }
            _stateContext.appStateEntity.transitionGame = true;
        }
    }
}