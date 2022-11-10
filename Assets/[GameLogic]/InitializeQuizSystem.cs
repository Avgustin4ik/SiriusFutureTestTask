using System.Collections.Generic;
using Core.Configs;
using Entitas;
using UI;
using UnityEngine;

public class InitializeQuizSystem : ReactiveSystem<GameEntity>
{
    private readonly IGroup<UiEntity> _riddlePanelGroup;
    private readonly IGroup<UiEntity> _liveCounterGroup;
    private readonly IGroup<UiEntity> _guessLetterGroup;

    public InitializeQuizSystem(GameContext gameContext, UiContext uiContext) : base(gameContext)
    {
        _riddlePanelGroup = uiContext.GetGroup(UiMatcher.AllOf(
            UiMatcher.LetterBoxPanel,
            UiMatcher.LetterBoxRiddlePanel));
        _guessLetterGroup = uiContext.GetGroup(UiMatcher.AllOf(
            UiMatcher.LetterBox,
            UiMatcher.LetterGuess));
        _liveCounterGroup = uiContext.GetGroup(UiMatcher.PlayerTryCounter);
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.RiddleWord.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var guessEntity in _guessLetterGroup.GetEntities())
        {
            guessEntity.Destroy();
        }
        foreach (var quizRules in entities)
        {
            var gameConfig = ConfigsCatalogsManager.GetConfig<GameConfig>();
            var riddleWord = quizRules.riddleWord.value;
            var charCount = riddleWord.Length;
            foreach (var panelEntity in _riddlePanelGroup.GetEntities())
            {
                foreach (var letter in riddleWord)
                {
                    var letterBoxEntity = Contexts.sharedInstance.ui.CreateEntity();
                    var letterBox = GameObject.Instantiate<LetterBox>(
                        gameConfig.LetterBoxPrefab, panelEntity.rectTransform.value);
                    letterBox.Init(letterBoxEntity);
                    letterBoxEntity.isLetterGuess = true;
                    letterBoxEntity.ReplaceLetterLabel(letter);
                    letterBoxEntity.ReplaceLetterLabelHide(true);
                }
            }
            
        }

        foreach (var uiEntity in _liveCounterGroup.GetEntities())
        {
            uiEntity.isUIElementShow = true;
        }
        
        
    }
}