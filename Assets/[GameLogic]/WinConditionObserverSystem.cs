using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class WinConditionObserverSystem : ReactiveSystem<GameEntity>
{
    private readonly IGroup<UiEntity> _letterBoxGroup;
    private readonly IGroup<GameEntity> _quizGroup;

    public WinConditionObserverSystem(GameContext gameContext, UiContext uiContext) : base(gameContext)
    {
        _letterBoxGroup = uiContext.GetGroup(UiMatcher.AllOf(
            UiMatcher.LetterBox,
            UiMatcher.LetterGuess));
        _quizGroup = gameContext.GetGroup(GameMatcher.QuizRules);
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.LetterBoxOpen);
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var entity in entities)
        {
            var counter = 0;
            foreach (var uiEntity in _letterBoxGroup.GetEntities())
            {
                if (uiEntity.letterLabelHide.value == false) counter++;
            }
            foreach (var quizEntity in _quizGroup.GetEntities())
            {
                if(counter != quizEntity.riddleWord.value.Length) continue;
                Contexts.sharedInstance.state.appStateEntity.transitionVictory = true;
                Debug.Log("YOU WIN");
            }
        }
    }
}