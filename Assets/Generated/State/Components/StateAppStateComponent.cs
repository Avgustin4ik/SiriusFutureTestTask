//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class StateContext {

    public StateEntity appStateEntity { get { return GetGroup(StateMatcher.AppState).GetSingleEntity(); } }

    public bool isStaticAppState {
        get { return appStateEntity != null; }
        set {
            var entity = appStateEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isStaticAppState = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class StateEntity {

    static readonly Core.ApplicationStates.AppStateComponent appStateComponent = new Core.ApplicationStates.AppStateComponent();

    public bool isStaticAppState {
        get { return HasComponent(StateComponentsLookup.AppState); }
        set {
            if (value != isStaticAppState) {
                var index = StateComponentsLookup.AppState;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : appStateComponent;

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

    static Entitas.IMatcher<StateEntity> _matcherAppState;

    public static Entitas.IMatcher<StateEntity> AppState {
        get {
            if (_matcherAppState == null) {
                var matcher = (Entitas.Matcher<StateEntity>)Entitas.Matcher<StateEntity>.AllOf(StateComponentsLookup.AppState);
                matcher.componentNames = StateComponentsLookup.componentNames;
                _matcherAppState = matcher;
            }

            return _matcherAppState;
        }
    }
}