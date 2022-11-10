//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class UiGameObjectEnabledEventSystem : Entitas.ReactiveSystem<UiEntity> {

    readonly System.Collections.Generic.List<IUiGameObjectEnabledListener> _listenerBuffer;

    public UiGameObjectEnabledEventSystem(Contexts contexts) : base(contexts.ui) {
        _listenerBuffer = new System.Collections.Generic.List<IUiGameObjectEnabledListener>();
    }

    protected override Entitas.ICollector<UiEntity> GetTrigger(Entitas.IContext<UiEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(UiMatcher.GameObjectEnabled)
        );
    }

    protected override bool Filter(UiEntity entity) {
        return entity.hasGameObjectEnabled && entity.hasUiGameObjectEnabledListener;
    }

    protected override void Execute(System.Collections.Generic.List<UiEntity> entities) {
        foreach (var e in entities) {
            var component = e.gameObjectEnabled;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.uiGameObjectEnabledListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnGameObjectEnabled(e, component.value);
            }
        }
    }
}
