public class GameLoopSystems : Feature
{
    public GameLoopSystems(GameContext gameContext, UiContext uiContext)
    {
        Add(new StartGameSystem(gameContext, uiContext));
        Add(new LoadRiddleWordsSystem(gameContext, uiContext));
        // Add(new AddPlayerScoreSystem(gameContext, uiContext));
        Add(new RemovePlayerTryCountSystem(gameContext, uiContext));
        Add(new LooseConditionObserverSystem(gameContext, uiContext));
        Add(new WinConditionObserverSystem(gameContext, uiContext));
        //todo add win condition
    }
}