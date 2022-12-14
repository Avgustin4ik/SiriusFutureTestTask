//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class AnyGameEventSystem : Entitas.ReactiveSystem<StateEntity> {

    readonly Entitas.IGroup<StateEntity> _listeners;
    readonly System.Collections.Generic.List<StateEntity> _entityBuffer;
    readonly System.Collections.Generic.List<IAnyGameListener> _listenerBuffer;

    public AnyGameEventSystem(Contexts contexts) : base(contexts.state) {
        _listeners = contexts.state.GetGroup(StateMatcher.AnyGameListener);
        _entityBuffer = new System.Collections.Generic.List<StateEntity>();
        _listenerBuffer = new System.Collections.Generic.List<IAnyGameListener>();
    }

    protected override Entitas.ICollector<StateEntity> GetTrigger(Entitas.IContext<StateEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(StateMatcher.Game)
        );
    }

    protected override bool Filter(StateEntity entity) {
        return entity.transitionGame;
    }

    protected override void Execute(System.Collections.Generic.List<StateEntity> entities) {
        foreach (var e in entities) {
            
            foreach (var listenerEntity in _listeners.GetEntities(_entityBuffer)) {
                _listenerBuffer.Clear();
                _listenerBuffer.AddRange(listenerEntity.anyGameListener.value);
                foreach (var listener in _listenerBuffer) {
                    listener.OnAnyGame(e);
                }
            }
        }
    }
}
