//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public JoystickBackgroundSetActiveListenerComponent joystickBackgroundSetActiveListener { get { return (JoystickBackgroundSetActiveListenerComponent)GetComponent(GameComponentsLookup.JoystickBackgroundSetActiveListener); } }
    public bool hasJoystickBackgroundSetActiveListener { get { return HasComponent(GameComponentsLookup.JoystickBackgroundSetActiveListener); } }

    public void AddJoystickBackgroundSetActiveListener(System.Collections.Generic.List<IJoystickBackgroundSetActiveListener> newValue) {
        var index = GameComponentsLookup.JoystickBackgroundSetActiveListener;
        var component = (JoystickBackgroundSetActiveListenerComponent)CreateComponent(index, typeof(JoystickBackgroundSetActiveListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceJoystickBackgroundSetActiveListener(System.Collections.Generic.List<IJoystickBackgroundSetActiveListener> newValue) {
        var index = GameComponentsLookup.JoystickBackgroundSetActiveListener;
        var component = (JoystickBackgroundSetActiveListenerComponent)CreateComponent(index, typeof(JoystickBackgroundSetActiveListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveJoystickBackgroundSetActiveListener() {
        RemoveComponent(GameComponentsLookup.JoystickBackgroundSetActiveListener);
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

    static Entitas.IMatcher<GameEntity> _matcherJoystickBackgroundSetActiveListener;

    public static Entitas.IMatcher<GameEntity> JoystickBackgroundSetActiveListener {
        get {
            if (_matcherJoystickBackgroundSetActiveListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JoystickBackgroundSetActiveListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJoystickBackgroundSetActiveListener = matcher;
            }

            return _matcherJoystickBackgroundSetActiveListener;
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

    public void AddJoystickBackgroundSetActiveListener(IJoystickBackgroundSetActiveListener value) {
        var listeners = hasJoystickBackgroundSetActiveListener
            ? joystickBackgroundSetActiveListener.value
            : new System.Collections.Generic.List<IJoystickBackgroundSetActiveListener>();
        listeners.Add(value);
        ReplaceJoystickBackgroundSetActiveListener(listeners);
    }

    public void RemoveJoystickBackgroundSetActiveListener(IJoystickBackgroundSetActiveListener value, bool removeComponentWhenEmpty = true) {
        var listeners = joystickBackgroundSetActiveListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveJoystickBackgroundSetActiveListener();
        } else {
            ReplaceJoystickBackgroundSetActiveListener(listeners);
        }
    }
}
