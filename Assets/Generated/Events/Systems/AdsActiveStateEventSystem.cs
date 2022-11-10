//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class AdsActiveStateEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IAdsActiveStateListener> _listenerBuffer;

    public AdsActiveStateEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IAdsActiveStateListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.AdsActiveState)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasAdsActiveState && entity.hasAdsActiveStateListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.adsActiveState;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.adsActiveStateListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnAdsActiveState(e, component.value);
            }
        }
    }
}
