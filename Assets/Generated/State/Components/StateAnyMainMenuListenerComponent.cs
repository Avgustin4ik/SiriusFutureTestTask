//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class StateEntity {

    public AnyMainMenuListenerComponent anyMainMenuListener { get { return (AnyMainMenuListenerComponent)GetComponent(StateComponentsLookup.AnyMainMenuListener); } }
    public bool hasAnyMainMenuListener { get { return HasComponent(StateComponentsLookup.AnyMainMenuListener); } }

    public void AddAnyMainMenuListener(System.Collections.Generic.List<IAnyMainMenuListener> newValue) {
        var index = StateComponentsLookup.AnyMainMenuListener;
        var component = (AnyMainMenuListenerComponent)CreateComponent(index, typeof(AnyMainMenuListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyMainMenuListener(System.Collections.Generic.List<IAnyMainMenuListener> newValue) {
        var index = StateComponentsLookup.AnyMainMenuListener;
        var component = (AnyMainMenuListenerComponent)CreateComponent(index, typeof(AnyMainMenuListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyMainMenuListener() {
        RemoveComponent(StateComponentsLookup.AnyMainMenuListener);
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

    static Entitas.IMatcher<StateEntity> _matcherAnyMainMenuListener;

    public static Entitas.IMatcher<StateEntity> AnyMainMenuListener {
        get {
            if (_matcherAnyMainMenuListener == null) {
                var matcher = (Entitas.Matcher<StateEntity>)Entitas.Matcher<StateEntity>.AllOf(StateComponentsLookup.AnyMainMenuListener);
                matcher.componentNames = StateComponentsLookup.componentNames;
                _matcherAnyMainMenuListener = matcher;
            }

            return _matcherAnyMainMenuListener;
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

    public void AddAnyMainMenuListener(IAnyMainMenuListener value) {
        var listeners = hasAnyMainMenuListener
            ? anyMainMenuListener.value
            : new System.Collections.Generic.List<IAnyMainMenuListener>();
        listeners.Add(value);
        ReplaceAnyMainMenuListener(listeners);
    }

    public void RemoveAnyMainMenuListener(IAnyMainMenuListener value, bool removeComponentWhenEmpty = true) {
        var listeners = anyMainMenuListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyMainMenuListener();
        } else {
            ReplaceAnyMainMenuListener(listeners);
        }
    }
}
