//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UiEntity {

    public Core.Common.RectTransformComponent rectTransform { get { return (Core.Common.RectTransformComponent)GetComponent(UiComponentsLookup.RectTransform); } }
    public bool hasRectTransform { get { return HasComponent(UiComponentsLookup.RectTransform); } }

    public void AddRectTransform(UnityEngine.RectTransform newValue) {
        var index = UiComponentsLookup.RectTransform;
        var component = (Core.Common.RectTransformComponent)CreateComponent(index, typeof(Core.Common.RectTransformComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceRectTransform(UnityEngine.RectTransform newValue) {
        var index = UiComponentsLookup.RectTransform;
        var component = (Core.Common.RectTransformComponent)CreateComponent(index, typeof(Core.Common.RectTransformComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveRectTransform() {
        RemoveComponent(UiComponentsLookup.RectTransform);
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

    static Entitas.IMatcher<UiEntity> _matcherRectTransform;

    public static Entitas.IMatcher<UiEntity> RectTransform {
        get {
            if (_matcherRectTransform == null) {
                var matcher = (Entitas.Matcher<UiEntity>)Entitas.Matcher<UiEntity>.AllOf(UiComponentsLookup.RectTransform);
                matcher.componentNames = UiComponentsLookup.componentNames;
                _matcherRectTransform = matcher;
            }

            return _matcherRectTransform;
        }
    }
}
