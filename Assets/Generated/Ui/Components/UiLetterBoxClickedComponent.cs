//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UiEntity {

    static readonly UI.LetterBoxClickedComponent letterBoxClickedComponent = new UI.LetterBoxClickedComponent();

    public bool isLetterBoxClicked {
        get { return HasComponent(UiComponentsLookup.LetterBoxClicked); }
        set {
            if (value != isLetterBoxClicked) {
                var index = UiComponentsLookup.LetterBoxClicked;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : letterBoxClickedComponent;

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

    static Entitas.IMatcher<UiEntity> _matcherLetterBoxClicked;

    public static Entitas.IMatcher<UiEntity> LetterBoxClicked {
        get {
            if (_matcherLetterBoxClicked == null) {
                var matcher = (Entitas.Matcher<UiEntity>)Entitas.Matcher<UiEntity>.AllOf(UiComponentsLookup.LetterBoxClicked);
                matcher.componentNames = UiComponentsLookup.componentNames;
                _matcherLetterBoxClicked = matcher;
            }

            return _matcherLetterBoxClicked;
        }
    }
}