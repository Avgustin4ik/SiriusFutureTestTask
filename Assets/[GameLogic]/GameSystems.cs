using Entitas;
using GameCamera;

public sealed class GameSystems : Systems
{
    public GameSystems(Contexts contexts, GameConfig gameConfig)
    {
        Add(new QuizSystems(contexts.game, contexts.ui));
        Add(new GameLoopSystems(contexts.game, contexts.ui));
        Add(new UI.UISystems(contexts.game, contexts.state, contexts.ui));
        
        
        Add(new GameCameraSystems(contexts.game));
    }
}