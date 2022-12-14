//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class StateEntity {

    public AnyVictoryListenerComponent anyVictoryListener { get { return (AnyVictoryListenerComponent)GetComponent(StateComponentsLookup.AnyVictoryListener); } }
    public bool hasAnyVictoryListener { get { return HasComponent(StateComponentsLookup.AnyVictoryListener); } }

    public void AddAnyVictoryListener(System.Collections.Generic.List<IAnyVictoryListener> newValue) {
        var index = StateComponentsLookup.AnyVictoryListener;
        var component = (AnyVictoryListenerComponent)CreateComponent(index, typeof(AnyVictoryListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyVictoryListener(System.Collections.Generic.List<IAnyVictoryListener> newValue) {
        var index = StateComponentsLookup.AnyVictoryListener;
        var component = (AnyVictoryListenerComponent)CreateComponent(index, typeof(AnyVictoryListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyVictoryListener() {
        RemoveComponent(StateComponentsLookup.AnyVictoryListener);
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

    static Entitas.IMatcher<StateEntity> _matcherAnyVictoryListener;

    public static Entitas.IMatcher<StateEntity> AnyVictoryListener {
        get {
            if (_matcherAnyVictoryListener == null) {
                var matcher = (Entitas.Matcher<StateEntity>)Entitas.Matcher<StateEntity>.AllOf(StateComponentsLookup.AnyVictoryListener);
                matcher.componentNames = StateComponentsLookup.componentNames;
                _matcherAnyVictoryListener = matcher;
            }

            return _matcherAnyVictoryListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class StateEntity {

    public void AddAnyVictoryListener(IAnyVictoryListener value) {
        var listeners = hasAnyVictoryListener
            ? anyVictoryListener.value
            : new System.Collections.Generic.List<IAnyVictoryListener>();
        listeners.Add(value);
        ReplaceAnyVictoryListener(listeners);
    }

    public void RemoveAnyVictoryListener(IAnyVictoryListener value, bool removeComponentWhenEmpty = true) {
        var listeners = anyVictoryListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyVictoryListener();
        } else {
            ReplaceAnyVictoryListener(listeners);
        }
    }
}
