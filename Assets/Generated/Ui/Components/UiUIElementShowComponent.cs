//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UiEntity {

    static readonly UI.UIElementShowComponent uIElementShowComponent = new UI.UIElementShowComponent();

    public bool isUIElementShow {
        get { return HasComponent(UiComponentsLookup.UIElementShow); }
        set {
            if (value != isUIElementShow) {
                var index = UiComponentsLookup.UIElementShow;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : uIElementShowComponent;

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

    static Entitas.IMatcher<UiEntity> _matcherUIElementShow;

    public static Entitas.IMatcher<UiEntity> UIElementShow {
        get {
            if (_matcherUIElementShow == null) {
                var matcher = (Entitas.Matcher<UiEntity>)Entitas.Matcher<UiEntity>.AllOf(UiComponentsLookup.UIElementShow);
                matcher.componentNames = UiComponentsLookup.componentNames;
                _matcherUIElementShow = matcher;
            }

            return _matcherUIElementShow;
        }
    }
}
