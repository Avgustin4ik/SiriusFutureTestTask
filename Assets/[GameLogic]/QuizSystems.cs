using System;

public class QuizSystems : Feature
{
    public QuizSystems(GameContext gameContext, UiContext uiContext)
    {
        Add(new InitializeQuizSystem(gameContext, uiContext));
        Add(new GenerateKeyLetterBoxes(gameContext, uiContext));
        Add(new QuizMechanicSystem(gameContext, uiContext));
    }
}