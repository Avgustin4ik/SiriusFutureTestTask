using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Configs;
using Entitas;
using UI;
using UnityEngine;
using Random = System.Random;

public class GenerateKeyLetterBoxes : ReactiveSystem<GameEntity>
{
    private readonly IGroup<UiEntity> _keyPanelGroup;
    private readonly IGroup<UiEntity> _keyLetterGroup;

    public GenerateKeyLetterBoxes(GameContext gameContext, UiContext uiContext) : base(gameContext)
    {
        _keyPanelGroup = uiContext.GetGroup(UiMatcher.AllOf(
            UiMatcher.LetterBoxPanel,
            UiMatcher.LetterBoxKeyPanel));
        _keyLetterGroup = uiContext.GetGroup(UiMatcher.AllOf(
            UiMatcher.LetterBox,
            UiMatcher.LetterKey));
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
        foreach (var letterBoxEntity in _keyLetterGroup.GetEntities())
        {
            letterBoxEntity.Destroy();
        }
        foreach (var quizRulesEntity in entities)
        {
            var gameConfig = ConfigsCatalogsManager.GetConfig<GameConfig>();

            var keyLettersString = quizRulesEntity.riddleWord.value.ToUpper();
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // var count = keyLettersString.Length / 2;
            // var rnd = new Random();
            // var randomLetters = alphabet.Where(x => !keyLettersString.Contains(x))
            //     .OrderBy(x => rnd.Next())
            //     .Take(count)
            //     .ToArray();
            // keyLettersString += new string(randomLetters);
            // keyLettersString = new string(keyLettersString.OrderBy(x => rnd.Next()).ToArray()); //сложно
            foreach (var panelEntity in _keyPanelGroup.GetEntities())
            {
                // foreach (var letterKey in keyLettersString)
                foreach (var letterKey in alphabet)
                {
                    var letterBoxEntity = Contexts.sharedInstance.ui.CreateEntity();
                    var letterBox = GameObject.Instantiate<LetterBox>(
                        gameConfig.LetterBoxPrefab, panelEntity.rectTransform.value);
                    letterBox.Init(letterBoxEntity);
                    letterBoxEntity.isLetterKey = true;
                    letterBoxEntity.ReplaceLetterLabel(letterKey);
                    letterBoxEntity.ReplaceLetterLabelHide(false);
                }
                
            }

        }
    }
}