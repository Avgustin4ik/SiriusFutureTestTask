//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Core.Input.JoystickFloatingTypeComponent joystickFloatingTypeComponent = new Core.Input.JoystickFloatingTypeComponent();

    public bool isJoystickFloatingType {
        get { return HasComponent(GameComponentsLookup.JoystickFloatingType); }
        set {
            if (value != isJoystickFloatingType) {
                var index = GameComponentsLookup.JoystickFloatingType;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : joystickFloatingTypeComponent;

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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherJoystickFloatingType;

    public static Entitas.IMatcher<GameEntity> JoystickFloatingType {
        get {
            if (_matcherJoystickFloatingType == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoystickFloatingType);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoystickFloatingType = matcher;
            }

            return _matcherJoystickFloatingType;
        }
    }
}