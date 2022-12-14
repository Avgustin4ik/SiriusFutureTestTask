//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UiEntity {

    public ClickedListenerComponent clickedListener { get { return (ClickedListenerComponent)GetComponent(UiComponentsLookup.ClickedListener); } }
    public bool hasClickedListener { get { return HasComponent(UiComponentsLookup.ClickedListener); } }

    public void AddClickedListener(System.Collections.Generic.List<IClickedListener> newValue) {
        var index = UiComponentsLookup.ClickedListener;
        var component = (ClickedListenerComponent)CreateComponent(index, typeof(ClickedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceClickedListener(System.Collections.Generic.List<IClickedListener> newValue) {
        var index = UiComponentsLookup.ClickedListener;
        var component = (ClickedListenerComponent)CreateComponent(index, typeof(ClickedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveClickedListener() {
        RemoveComponent(UiComponentsLookup.ClickedListener);
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

    static Entitas.IMatcher<UiEntity> _matcherClickedListener;

    public static Entitas.IMatcher<UiEntity> ClickedListener {
        get {
            if (_matcherClickedListener == null) {
                var matcher = (Entitas.Matcher<UiEntity>)Entitas.Matcher<UiEntity>.AllOf(UiComponentsLookup.ClickedListener);
                matcher.componentNames = UiComponentsLookup.componentNames;
                _matcherClickedListener = matcher;
            }

            return _matcherClickedListener;
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
public partial class UiEntity {

    public void AddClickedListener(IClickedListener value) {
        var listeners = hasClickedListener
            ? clickedListener.value
            : new System.Collections.Generic.List<IClickedListener>();
        listeners.Add(value);
        ReplaceClickedListener(listeners);
    }

    public void RemoveClickedListener(IClickedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = clickedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveClickedListener();
        } else {
            ReplaceClickedListener(listeners);
        }
    }
}
