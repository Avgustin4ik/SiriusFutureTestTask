//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InAppPurchaseEntity {

    public InAppPurchaseServiceInitializedListenerComponent inAppPurchaseServiceInitializedListener { get { return (InAppPurchaseServiceInitializedListenerComponent)GetComponent(InAppPurchaseComponentsLookup.InAppPurchaseServiceInitializedListener); } }
    public bool hasInAppPurchaseServiceInitializedListener { get { return HasComponent(InAppPurchaseComponentsLookup.InAppPurchaseServiceInitializedListener); } }

    public void AddInAppPurchaseServiceInitializedListener(System.Collections.Generic.List<IInAppPurchaseServiceInitializedListener> newValue) {
        var index = InAppPurchaseComponentsLookup.InAppPurchaseServiceInitializedListener;
        var component = (InAppPurchaseServiceInitializedListenerComponent)CreateComponent(index, typeof(InAppPurchaseServiceInitializedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceInAppPurchaseServiceInitializedListener(System.Collections.Generic.List<IInAppPurchaseServiceInitializedListener> newValue) {
        var index = InAppPurchaseComponentsLookup.InAppPurchaseServiceInitializedListener;
        var component = (InAppPurchaseServiceInitializedListenerComponent)CreateComponent(index, typeof(InAppPurchaseServiceInitializedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveInAppPurchaseServiceInitializedListener() {
        RemoveComponent(InAppPurchaseComponentsLookup.InAppPurchaseServiceInitializedListener);
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
public sealed partial class InAppPurchaseMatcher {

    static Entitas.IMatcher<InAppPurchaseEntity> _matcherInAppPurchaseServiceInitializedListener;

    public static Entitas.IMatcher<InAppPurchaseEntity> InAppPurchaseServiceInitializedListener {
        get {
            if (_matcherInAppPurchaseServiceInitializedListener == null) {
                var matcher = (Entitas.Matcher<InAppPurchaseEntity>)Entitas.Matcher<InAppPurchaseEntity>.AllOf(InAppPurchaseComponentsLookup.InAppPurchaseServiceInitializedListener);
                matcher.componentNames = InAppPurchaseComponentsLookup.componentNames;
                _matcherInAppPurchaseServiceInitializedListener = matcher;
            }

            return _matcherInAppPurchaseServiceInitializedListener;
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
public partial class InAppPurchaseEntity {

    public void AddInAppPurchaseServiceInitializedListener(IInAppPurchaseServiceInitializedListener value) {
        var listeners = hasInAppPurchaseServiceInitializedListener
            ? inAppPurchaseServiceInitializedListener.value
            : new System.Collections.Generic.List<IInAppPurchaseServiceInitializedListener>();
        listeners.Add(value);
        ReplaceInAppPurchaseServiceInitializedListener(listeners);
    }

    public void RemoveInAppPurchaseServiceInitializedListener(IInAppPurchaseServiceInitializedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = inAppPurchaseServiceInitializedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveInAppPurchaseServiceInitializedListener();
        } else {
            ReplaceInAppPurchaseServiceInitializedListener(listeners);
        }
    }
}
