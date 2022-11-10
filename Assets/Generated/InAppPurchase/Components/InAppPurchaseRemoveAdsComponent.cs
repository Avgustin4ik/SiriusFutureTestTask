//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InAppPurchaseEntity {

    static readonly Core.InAppPurchases.RemoveAdsComponent removeAdsComponent = new Core.InAppPurchases.RemoveAdsComponent();

    public bool isRemoveAds {
        get { return HasComponent(InAppPurchaseComponentsLookup.RemoveAds); }
        set {
            if (value != isRemoveAds) {
                var index = InAppPurchaseComponentsLookup.RemoveAds;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : removeAdsComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<InAppPurchaseEntity> _matcherRemoveAds;

    public static Entitas.IMatcher<InAppPurchaseEntity> RemoveAds {
        get {
            if (_matcherRemoveAds == null) {
                var matcher = (Entitas.Matcher<InAppPurchaseEntity>)Entitas.Matcher<InAppPurchaseEntity>.AllOf(InAppPurchaseComponentsLookup.RemoveAds);
                matcher.componentNames = InAppPurchaseComponentsLookup.componentNames;
                _matcherRemoveAds = matcher;
            }

            return _matcherRemoveAds;
        }
    }
}
