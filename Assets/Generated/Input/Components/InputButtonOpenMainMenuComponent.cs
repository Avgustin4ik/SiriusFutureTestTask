//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    static readonly Core.Input.ButtonOpenMainMenuComponent buttonOpenMainMenuComponent = new Core.Input.ButtonOpenMainMenuComponent();

    public bool isButtonOpenMainMenu {
        get { return HasComponent(InputComponentsLookup.ButtonOpenMainMenu); }
        set {
            if (value != isButtonOpenMainMenu) {
                var index = InputComponentsLookup.ButtonOpenMainMenu;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : buttonOpenMainMenuComponent;

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

    static Entitas.IMatcher<InputEntity> _matcherButtonOpenMainMenu;

    public static Entitas.IMatcher<InputEntity> ButtonOpenMainMenu {
        get {
            if (_matcherButtonOpenMainMenu == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.ButtonOpenMainMenu);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherButtonOpenMainMenu = matcher;
            }

            return _matcherButtonOpenMainMenu;
        }
    }
}
