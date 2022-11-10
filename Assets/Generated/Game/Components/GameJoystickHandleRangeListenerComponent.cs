//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public JoystickHandleRangeListenerComponent joystickHandleRangeListener { get { return (JoystickHandleRangeListenerComponent)GetComponent(GameComponentsLookup.JoystickHandleRangeListener); } }
    public bool hasJoystickHandleRangeListener { get { return HasComponent(GameComponentsLookup.JoystickHandleRangeListener); } }

    public void AddJoystickHandleRangeListener(System.Collections.Generic.List<IJoystickHandleRangeListener> newValue) {
        var index = GameComponentsLookup.JoystickHandleRangeListener;
        var component = (JoystickHandleRangeListenerComponent)CreateComponent(index, typeof(JoystickHandleRangeListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceJoystickHandleRangeListener(System.Collections.Generic.List<IJoystickHandleRangeListener> newValue) {
        var index = GameComponentsLookup.JoystickHandleRangeListener;
        var component = (JoystickHandleRangeListenerComponent)CreateComponent(index, typeof(JoystickHandleRangeListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveJoystickHandleRangeListener() {
        RemoveComponent(GameComponentsLookup.JoystickHandleRangeListener);
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

    static Entitas.IMatcher<GameEntity> _matcherJoystickHandleRangeListener;

    public static Entitas.IMatcher<GameEntity> JoystickHandleRangeListener {
        get {
            if (_matcherJoystickHandleRangeListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoystickHandleRangeListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoystickHandleRangeListener = matcher;
            }

            return _matcherJoystickHandleRangeListener;
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
public partial class GameEntity {

    public void AddJoystickHandleRangeListener(IJoystickHandleRangeListener value) {
        var listeners = hasJoystickHandleRangeListener
            ? joystickHandleRangeListener.value
            : new System.Collections.Generic.List<IJoystickHandleRangeListener>();
        listeners.Add(value);
        ReplaceJoystickHandleRangeListener(listeners);
    }

    public void RemoveJoystickHandleRangeListener(IJoystickHandleRangeListener value, bool removeComponentWhenEmpty = true) {
        var listeners = joystickHandleRangeListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveJoystickHandleRangeListener();
        } else {
            ReplaceJoystickHandleRangeListener(listeners);
        }
    }
}