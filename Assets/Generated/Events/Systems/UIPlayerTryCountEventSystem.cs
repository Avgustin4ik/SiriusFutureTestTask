//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class UIPlayerTryCountEventSystem : Entitas.ReactiveSystem<UiEntity> {

    readonly System.Collections.Generic.List<IUIPlayerTryCountListener> _listenerBuffer;

    public UIPlayerTryCountEventSystem(Contexts contexts) : base(contexts.ui) {
        _listenerBuffer = new System.Collections.Generic.List<IUIPlayerTryCountListener>();
    }

    protected override Entitas.ICollector<UiEntity> GetTrigger(Entitas.IContext<UiEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(UiMatcher.UIPlayerTryCount)
        );
    }

    protected override bool Filter(UiEntity entity) {
        return entity.hasUIPlayerTryCount && entity.hasUIPlayerTryCountListener;
    }

    protected override void Execute(System.Collections.Generic.List<UiEntity> entities) {
        foreach (var e in entities) {
            var component = e.uIPlayerTryCount;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.uIPlayerTryCountListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnUIPlayerTryCount(e, component.value);
            }
        }
    }
}
