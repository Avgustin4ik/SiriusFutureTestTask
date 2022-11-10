//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    static readonly Core.Input.ButtonCompleteGameComponent buttonCompleteGameComponent = new Core.Input.ButtonCompleteGameComponent();

    public bool isButtonCompleteGame {
        get { return HasComponent(InputComponentsLookup.ButtonCompleteGame); }
        set {
            if (value != isButtonCompleteGame) {
                var index = InputComponentsLookup.ButtonCompleteGame;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : buttonCompleteGameComponent;

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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherButtonCompleteGame;

    public static Entitas.IMatcher<InputEntity> ButtonCompleteGame {
        get {
            if (_matcherButtonCompleteGame == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.ButtonCompleteGame);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherButtonCompleteGame = matcher;
            }

            return _matcherButtonCompleteGame;
        }
    }
}