using Entitas;
using GameCamera;

public sealed class GameSystems : Systems
{
    public GameSystems(Contexts contexts, GameConfig gameConfig)
    {
        // add you game logic here
        Add(new GameLoadPlayerDataCompleteReactSystem(contexts.game, contexts.level));
        Add(new QuizSystems(contexts.game, contexts.ui));
        Add(new GameLoopSystems(contexts.game, contexts.ui));
        // ui logic here
        Add(new UI.UISystems(contexts.game, contexts.state, contexts.ui));
        
        
        Add(new GameCameraSystems(contexts.game));
    }
}