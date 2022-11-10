//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InAppPurchaseEntity {

    public Core.InAppPurchases.ProductStatusComponent productStatus { get { return (Core.InAppPurchases.ProductStatusComponent)GetComponent(InAppPurchaseComponentsLookup.ProductStatus); } }
    public bool hasProductStatus { get { return HasComponent(InAppPurchaseComponentsLookup.ProductStatus); } }

    public void AddProductStatus(bool newValue) {
        var index = InAppPurchaseComponentsLookup.ProductStatus;
        var component = (Core.InAppPurchases.ProductStatusComponent)CreateComponent(index, typeof(Core.InAppPurchases.ProductStatusComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceProductStatus(bool newValue) {
        var index = InAppPurchaseComponentsLookup.ProductStatus;
        var component = (Core.InAppPurchases.ProductStatusComponent)CreateComponent(index, typeof(Core.InAppPurchases.ProductStatusComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveProductStatus() {
        RemoveComponent(InAppPurchaseComponentsLookup.ProductStatus);
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

    static Entitas.IMatcher<InAppPurchaseEntity> _matcherProductStatus;

    public static Entitas.IMatcher<InAppPurchaseEntity> ProductStatus {
        get {
            if (_matcherProductStatus == null) {
                var matcher = (Entitas.Matcher<InAppPurchaseEntity>)Entitas.Matcher<InAppPurchaseEntity>.AllOf(InAppPurchaseComponentsLookup.ProductStatus);
                matcher.componentNames = InAppPurchaseComponentsLookup.componentNames;
                _matcherProductStatus = matcher;
            }

            return _matcherProductStatus;
        }
    }
}