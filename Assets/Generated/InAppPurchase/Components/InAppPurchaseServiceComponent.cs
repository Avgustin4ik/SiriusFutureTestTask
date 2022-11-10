//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InAppPurchaseContext {

    public InAppPurchaseEntity serviceEntity { get { return GetGroup(InAppPurchaseMatcher.Service).GetSingleEntity(); } }
    public Core.InAppPurchases.ServiceComponent service { get { return serviceEntity.service; } }
    public bool hasService { get { return serviceEntity != null; } }

    public InAppPurchaseEntity SetService(Core.InAppPurchases.IInAppPurchasesService newValue) {
        if (hasService) {
            throw new Entitas.EntitasException("Could not set Service!\n" + this + " already has an entity with Core.InAppPurchases.ServiceComponent!",
                "You should check if the context already has a serviceEntity before setting it or use context.ReplaceService().");
        }
        var entity = CreateEntity();
        entity.AddService(newValue);
        return entity;
    }

    public void ReplaceService(Core.InAppPurchases.IInAppPurchasesService newValue) {
        var entity = serviceEntity;
        if (entity == null) {
            entity = SetService(newValue);
        } else {
            entity.ReplaceService(newValue);
        }
    }

    public void RemoveService() {
        serviceEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InAppPurchaseEntity {

    public Core.InAppPurchases.ServiceComponent service { get { return (Core.InAppPurchases.ServiceComponent)GetComponent(InAppPurchaseComponentsLookup.Service); } }
    public bool hasService { get { return HasComponent(InAppPurchaseComponentsLookup.Service); } }

    public void AddService(Core.InAppPurchases.IInAppPurchasesService newValue) {
        var index = InAppPurchaseComponentsLookup.Service;
        var component = (Core.InAppPurchases.ServiceComponent)CreateComponent(index, typeof(Core.InAppPurchases.ServiceComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceService(Core.InAppPurchases.IInAppPurchasesService newValue) {
        var index = InAppPurchaseComponentsLookup.Service;
        var component = (Core.InAppPurchases.ServiceComponent)CreateComponent(index, typeof(Core.InAppPurchases.ServiceComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveService() {
        RemoveComponent(InAppPurchaseComponentsLookup.Service);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InAppPurchaseMatcher {

    static Entitas.IMatcher<InAppPurchaseEntity> _matcherService;

    public static Entitas.IMatcher<InAppPurchaseEntity> Service {
        get {
            if (_matcherService == null) {
                var matcher = (Entitas.Matcher<InAppPurchaseEntity>)Entitas.Matcher<InAppPurchaseEntity>.AllOf(InAppPurchaseComponentsLookup.Service);
                matcher.componentNames = InAppPurchaseComponentsLookup.componentNames;
                _matcherService = matcher;
            }

            return _matcherService;
        }
    }
}
