using System;
using System.Collections.Generic;
using System.Linq;
using Core.Configs;
using Entitas;

namespace Core.ApplicationStates
{
    public class RestartLevelTransitionListenerSystem : ReactiveSystem<StateEntity>
    {
        private readonly StateContext _stateContext;
        private readonly IGroup<GameEntity> _quizRuleGroup;
        private readonly IGroup<UiEntity> _uiTryCounterGroup;

        public RestartLevelTransitionListenerSystem(StateContext stateContext) : base(stateContext)
        {
            _stateContext = stateContext;
            _quizRuleGroup = Contexts.sharedInstance.game.GetGroup(GameMatcher.QuizRules);
            _uiTryCounterGroup = Contexts.sharedInstance.ui.GetGroup(UiMatcher.UIPlayerTryCount);
        }

        protected override ICollector<StateEntity> GetTrigger(IContext<StateEntity> context)
        {
            return context.CreateCollector(StateMatcher.Restart);
        }

        protected override bool Filter(StateEntity entity)
        {
            return true;
        }

        protected override void Execute(List<StateEntity> entities)
        {
            _stateContext.appStateEntity.transitionMainMenu = true;
            var userData = Contexts.sharedInstance.game.userDataEntity;
            var playerTryCount = ConfigsCatalogsManager.GetConfig<GameConfig>().PlayerTryCount;
            userData.ReplacePlayerTryCount(playerTryCount);
            foreach (var uiEntity in _uiTryCounterGroup.GetEntities())
            {
                uiEntity.ReplaceUIPlayerTryCount(playerTryCount);
            }
            userData.ReplaceUserDataMoney(0);
            foreach (var quizRuleEntity in _quizRuleGroup.GetEntities())
            {
                var dataBase = quizRuleEntity.riddleWordsDatabase.value;
                var rnd = new Random();
                quizRuleEntity.ReplaceRiddleWordsDatabase(dataBase.OrderBy(x=> rnd.Next()).ToArray());
                quizRuleEntity.ReplaceRiddleWord(quizRuleEntity.riddleWordsDatabase.value.First());
            }
            
        }
    }
}