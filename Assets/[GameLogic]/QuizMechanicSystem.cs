using System.Collections.Generic;
using Entitas;
using Char = System.Char;

public class QuizMechanicSystem : ReactiveSystem<UiEntity>
{
    private readonly IGroup<UiEntity> _guessLettersGroup;

    public QuizMechanicSystem(GameContext gameContext, UiContext uiContext) : base(uiContext)
    {
        _guessLettersGroup = uiContext.GetGroup(UiMatcher.AllOf(
            UiMatcher.LetterBox,
            UiMatcher.LetterGuess));
    }

    protected override ICollector<UiEntity> GetTrigger(IContext<UiEntity> context)
    {
        return context.CreateCollector(UiMatcher.LetterBoxClicked);
    }

    protected override bool Filter(UiEntity entity)
    {
        return entity.isLetterBox 
            && entity.isLetterKey;
    }

    protected override void Execute(List<UiEntity> entities)
    {
        foreach (var keyEntity in entities)
        {
            var requestEntity = Contexts.sharedInstance.game.CreateEntity();
            foreach (var guessEntity in _guessLettersGroup.GetEntities())
            {
                if (keyEntity.letterLabel.value != Char.ToUpperInvariant(guessEntity.letterLabel.value)) continue;
                guessEntity.ReplaceLetterLabelHide(false);
                requestEntity.isLetterBoxOpen = true;//request with manual cleanup
            }

            if (requestEntity.isLetterBoxOpen == false) requestEntity.isLetterBoxFail = true;
            keyEntity.Destroy();
        }
    }
}