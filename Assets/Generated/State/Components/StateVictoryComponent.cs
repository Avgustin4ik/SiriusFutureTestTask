//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class StateEntity {

    static readonly Core.ApplicationStates.VictoryComponent victoryComponent = new Core.ApplicationStates.VictoryComponent();

    public bool transitionVictory {
        get { return HasComponent(StateComponentsLookup.Victory); }
        set {
            if (value != transitionVictory) {
                var index = StateComponentsLookup.Victory;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : victoryComponent;

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
public sealed partial class StateMatcher {

    static Entitas.IMatcher<StateEntity> _matcherVictory;

    public static Entitas.IMatcher<StateEntity> Victory {
        get {
            if (_matcherVictory == null) {
                var matcher = (Entitas.Matcher<StateEntity>)Entitas.Matcher<StateEntity>.AllOf(StateComponentsLookup.Victory);
                matcher.componentNames = StateComponentsLookup.componentNames;
                _matcherVictory = matcher;
            }

            return _matcherVictory;
        }
    }
}
