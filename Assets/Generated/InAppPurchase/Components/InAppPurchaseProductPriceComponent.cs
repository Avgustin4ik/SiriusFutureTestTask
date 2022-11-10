//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InAppPurchaseEntity {

    public Core.InAppPurchases.ProductPriceComponent productPrice { get { return (Core.InAppPurchases.ProductPriceComponent)GetComponent(InAppPurchaseComponentsLookup.ProductPrice); } }
    public bool hasProductPrice { get { return HasComponent(InAppPurchaseComponentsLookup.ProductPrice); } }

    public void AddProductPrice(string newValue) {
        var index = InAppPurchaseComponentsLookup.ProductPrice;
        var component = (Core.InAppPurchases.ProductPriceComponent)CreateComponent(index, typeof(Core.InAppPurchases.ProductPriceComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceProductPrice(string newValue) {
        var index = InAppPurchaseComponentsLookup.ProductPrice;
        var component = (Core.InAppPurchases.ProductPriceComponent)CreateComponent(index, typeof(Core.InAppPurchases.ProductPriceComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveProductPrice() {
        RemoveComponent(InAppPurchaseComponentsLookup.ProductPrice);
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

    static Entitas.IMatcher<InAppPurchaseEntity> _matcherProductPrice;

    public static Entitas.IMatcher<InAppPurchaseEntity> ProductPrice {
        get {
            if (_matcherProductPrice == null) {
                var matcher = (Entitas.Matcher<InAppPurchaseEntity>)Entitas.Matcher<InAppPurchaseEntity>.AllOf(InAppPurchaseComponentsLookup.ProductPrice);
                matcher.componentNames = InAppPurchaseComponentsLookup.componentNames;
                _matcherProductPrice = matcher;
            }

            return _matcherProductPrice;
        }
    }
}
