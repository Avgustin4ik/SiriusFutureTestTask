//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class AnyCompleteLevelEventSystem : Entitas.ReactiveSystem<StateEntity> {

    readonly Entitas.IGroup<StateEntity> _listeners;
    readonly System.Collections.Generic.List<StateEntity> _entityBuffer;
    readonly System.Collections.Generic.List<IAnyCompleteLevelListener> _listenerBuffer;

    public AnyCompleteLevelEventSystem(Contexts contexts) : base(contexts.state) {
        _listeners = contexts.state.GetGroup(StateMatcher.AnyCompleteLevelListener);
        _entityBuffer = new System.Collections.Generic.List<StateEntity>();
        _listenerBuffer = new System.Collections.Generic.List<IAnyCompleteLevelListener>();
    }

    protected override Entitas.ICollector<StateEntity> GetTrigger(Entitas.IContext<StateEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(StateMatcher.CompleteLevel)
        );
    }

    protected override bool Filter(StateEntity entity) {
        return entity.transitionCompleteLevel;
    }

    protected override void Execute(System.Collections.Generic.List<StateEntity> entities) {
        foreach (var e in entities) {
            
            foreach (var listenerEntity in _listeners.GetEntities(_entityBuffer)) {
                _listenerBuffer.Clear();
                _listenerBuffer.AddRange(listenerEntity.anyCompleteLevelListener.value);
                foreach (var listener in _listenerBuffer) {
                    listener.OnAnyCompleteLevel(e);
                }
            }
        }
    }
}
