//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class AdvertisementEntity {

    static readonly Core.Advertisement.DisableAdvertisementComponent disableAdvertisementComponent = new Core.Advertisement.DisableAdvertisementComponent();

    public bool requestDisableAdvertisement {
        get { return HasComponent(AdvertisementComponentsLookup.DisableAdvertisement); }
        set {
            if (value != requestDisableAdvertisement) {
                var index = AdvertisementComponentsLookup.DisableAdvertisement;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : disableAdvertisementComponent;

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
public sealed partial class AdvertisementMatcher {

    static Entitas.IMatcher<AdvertisementEntity> _matcherDisableAdvertisement;

    public static Entitas.IMatcher<AdvertisementEntity> DisableAdvertisement {
        get {
            if (_matcherDisableAdvertisement == null) {
                var matcher = (Entitas.Matcher<AdvertisementEntity>)Entitas.Matcher<AdvertisementEntity>.AllOf(AdvertisementComponentsLookup.DisableAdvertisement);
                matcher.componentNames = AdvertisementComponentsLookup.componentNames;
                _matcherDisableAdvertisement = matcher;
            }

            return _matcherDisableAdvertisement;
        }
    }
}
