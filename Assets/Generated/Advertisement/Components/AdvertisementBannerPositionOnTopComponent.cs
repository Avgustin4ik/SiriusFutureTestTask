//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class AdvertisementEntity {

    static readonly Core.Advertisement.BannerPositionOnTopComponent bannerPositionOnTopComponent = new Core.Advertisement.BannerPositionOnTopComponent();

    public bool requestBannerPositionOnTop {
        get { return HasComponent(AdvertisementComponentsLookup.BannerPositionOnTop); }
        set {
            if (value != requestBannerPositionOnTop) {
                var index = AdvertisementComponentsLookup.BannerPositionOnTop;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : bannerPositionOnTopComponent;

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

    static Entitas.IMatcher<AdvertisementEntity> _matcherBannerPositionOnTop;

    public static Entitas.IMatcher<AdvertisementEntity> BannerPositionOnTop {
        get {
            if (_matcherBannerPositionOnTop == null) {
                var matcher = (Entitas.Matcher<AdvertisementEntity>)Entitas.Matcher<AdvertisementEntity>.AllOf(AdvertisementComponentsLookup.BannerPositionOnTop);
                matcher.componentNames = AdvertisementComponentsLookup.componentNames;
                _matcherBannerPositionOnTop = matcher;
            }

            return _matcherBannerPositionOnTop;
        }
    }
}