//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UiEntity {

    static readonly UI.UIElementHideComponent uIElementHideComponent = new UI.UIElementHideComponent();

    public bool isUIElementHide {
        get { return HasComponent(UiComponentsLookup.UIElementHide); }
        set {
            if (value != isUIElementHide) {
                var index = UiComponentsLookup.UIElementHide;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : uIElementHideComponent;

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
public sealed partial class UiMatcher {

    static Entitas.IMatcher<UiEntity> _matcherUIElementHide;

    public static Entitas.IMatcher<UiEntity> UIElementHide {
        get {
            if (_matcherUIElementHide == null) {
                var matcher = (Entitas.Matcher<UiEntity>)Entitas.Matcher<UiEntity>.AllOf(UiComponentsLookup.UIElementHide);
                matcher.componentNames = UiComponentsLookup.componentNames;
                _matcherUIElementHide = matcher;
            }

            return _matcherUIElementHide;
        }
    }
}
