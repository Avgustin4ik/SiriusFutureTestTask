//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UiEntity {

    public LetterLabelListenerComponent letterLabelListener { get { return (LetterLabelListenerComponent)GetComponent(UiComponentsLookup.LetterLabelListener); } }
    public bool hasLetterLabelListener { get { return HasComponent(UiComponentsLookup.LetterLabelListener); } }

    public void AddLetterLabelListener(System.Collections.Generic.List<ILetterLabelListener> newValue) {
        var index = UiComponentsLookup.LetterLabelListener;
        var component = (LetterLabelListenerComponent)CreateComponent(index, typeof(LetterLabelListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceLetterLabelListener(System.Collections.Generic.List<ILetterLabelListener> newValue) {
        var index = UiComponentsLookup.LetterLabelListener;
        var component = (LetterLabelListenerComponent)CreateComponent(index, typeof(LetterLabelListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveLetterLabelListener() {
        RemoveComponent(UiComponentsLookup.LetterLabelListener);
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

    static Entitas.IMatcher<UiEntity> _matcherLetterLabelListener;

    public static Entitas.IMatcher<UiEntity> LetterLabelListener {
        get {
            if (_matcherLetterLabelListener == null) {
                var matcher = (Entitas.Matcher<UiEntity>)Entitas.Matcher<UiEntity>.AllOf(UiComponentsLookup.LetterLabelListener);
                matcher.componentNames = UiComponentsLookup.componentNames;
                _matcherLetterLabelListener = matcher;
            }

            return _matcherLetterLabelListener;
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

    public void AddLetterLabelListener(ILetterLabelListener value) {
        var listeners = hasLetterLabelListener
            ? letterLabelListener.value
            : new System.Collections.Generic.List<ILetterLabelListener>();
        listeners.Add(value);
        ReplaceLetterLabelListener(listeners);
    }

    public void RemoveLetterLabelListener(ILetterLabelListener value, bool removeComponentWhenEmpty = true) {
        var listeners = letterLabelListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveLetterLabelListener();
        } else {
            ReplaceLetterLabelListener(listeners);
        }
    }
}
