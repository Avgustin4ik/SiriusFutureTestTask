//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UiEntity {

    static readonly UI.UIPlayerMoneyShowComponent uIPlayerMoneyShowComponent = new UI.UIPlayerMoneyShowComponent();

    public bool isUIPlayerMoneyShow {
        get { return HasComponent(UiComponentsLookup.UIPlayerMoneyShow); }
        set {
            if (value != isUIPlayerMoneyShow) {
                var index = UiComponentsLookup.UIPlayerMoneyShow;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : uIPlayerMoneyShowComponent;

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

    static Entitas.IMatcher<UiEntity> _matcherUIPlayerMoneyShow;

    public static Entitas.IMatcher<UiEntity> UIPlayerMoneyShow {
        get {
            if (_matcherUIPlayerMoneyShow == null) {
                var matcher = (Entitas.Matcher<UiEntity>)Entitas.Matcher<UiEntity>.AllOf(UiComponentsLookup.UIPlayerMoneyShow);
                matcher.componentNames = UiComponentsLookup.componentNames;
                _matcherUIPlayerMoneyShow = matcher;
            }

            return _matcherUIPlayerMoneyShow;
        }
    }
}
