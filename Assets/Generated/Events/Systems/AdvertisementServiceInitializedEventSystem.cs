//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class AdvertisementServiceInitializedEventSystem : Entitas.ReactiveSystem<AdvertisementEntity> {

    readonly System.Collections.Generic.List<IAdvertisementServiceInitializedListener> _listenerBuffer;

    public AdvertisementServiceInitializedEventSystem(Contexts contexts) : base(contexts.advertisement) {
        _listenerBuffer = new System.Collections.Generic.List<IAdvertisementServiceInitializedListener>();
    }

    protected override Entitas.ICollector<AdvertisementEntity> GetTrigger(Entitas.IContext<AdvertisementEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(AdvertisementMatcher.AdvertisementServiceInitialized)
        );
    }

    protected override bool Filter(AdvertisementEntity entity) {
        return entity.isAdvertisementServiceInitialized && entity.hasAdvertisementServiceInitializedListener;
    }

    protected override void Execute(System.Collections.Generic.List<AdvertisementEntity> entities) {
        foreach (var e in entities) {
            
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.advertisementServiceInitializedListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnAdvertisementServiceInitialized(e);
            }
        }
    }
}