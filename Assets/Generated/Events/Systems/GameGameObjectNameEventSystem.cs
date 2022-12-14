//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class GameGameObjectNameEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IGameGameObjectNameListener> _listenerBuffer;

    public GameGameObjectNameEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IGameGameObjectNameListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.GameObjectName)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasGameObjectName && entity.hasGameGameObjectNameListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.gameObjectName;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.gameGameObjectNameListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnGameObjectName(e, component.value);
            }
        }
    }
}
