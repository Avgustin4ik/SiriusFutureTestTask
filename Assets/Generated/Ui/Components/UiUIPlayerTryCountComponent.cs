//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UiEntity {

    public UI.UIPlayerTryCountComponent uIPlayerTryCount { get { return (UI.UIPlayerTryCountComponent)GetComponent(UiComponentsLookup.UIPlayerTryCount); } }
    public bool hasUIPlayerTryCount { get { return HasComponent(UiComponentsLookup.UIPlayerTryCount); } }

    public void AddUIPlayerTryCount(int newValue) {
        var index = UiComponentsLookup.UIPlayerTryCount;
        var component = (UI.UIPlayerTryCountComponent)CreateComponent(index, typeof(UI.UIPlayerTryCountComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceUIPlayerTryCount(int newValue) {
        var index = UiComponentsLookup.UIPlayerTryCount;
        var component = (UI.UIPlayerTryCountComponent)CreateComponent(index, typeof(UI.UIPlayerTryCountComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveUIPlayerTryCount() {
        RemoveComponent(UiComponentsLookup.UIPlayerTryCount);
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

    static Entitas.IMatcher<UiEntity> _matcherUIPlayerTryCount;

    public static Entitas.IMatcher<UiEntity> UIPlayerTryCount {
        get {
            if (_matcherUIPlayerTryCount == null) {
                var matcher = (Entitas.Matcher<UiEntity>)Entitas.Matcher<UiEntity>.AllOf(UiComponentsLookup.UIPlayerTryCount);
                matcher.componentNames = UiComponentsLookup.componentNames;
                _matcherUIPlayerTryCount = matcher;
            }

            return _matcherUIPlayerTryCount;
        }
    }
}
