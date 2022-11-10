//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class AnalyticEntity {

    public Core.Analytics.VoodooGameLevelFinishEventComponent voodooGameLevelFinishEvent { get { return (Core.Analytics.VoodooGameLevelFinishEventComponent)GetComponent(AnalyticComponentsLookup.VoodooGameLevelFinishEvent); } }
    public bool hasVoodooGameLevelFinishEvent { get { return HasComponent(AnalyticComponentsLookup.VoodooGameLevelFinishEvent); } }

    public void AddVoodooGameLevelFinishEvent(Adapters.AnalyticsConfig.EventGameLevelParameters newValue) {
        var index = AnalyticComponentsLookup.VoodooGameLevelFinishEvent;
        var component = (Core.Analytics.VoodooGameLevelFinishEventComponent)CreateComponent(index, typeof(Core.Analytics.VoodooGameLevelFinishEventComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceVoodooGameLevelFinishEvent(Adapters.AnalyticsConfig.EventGameLevelParameters newValue) {
        var index = AnalyticComponentsLookup.VoodooGameLevelFinishEvent;
        var component = (Core.Analytics.VoodooGameLevelFinishEventComponent)CreateComponent(index, typeof(Core.Analytics.VoodooGameLevelFinishEventComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveVoodooGameLevelFinishEvent() {
        RemoveComponent(AnalyticComponentsLookup.VoodooGameLevelFinishEvent);
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
public sealed partial class AnalyticMatcher {

    static Entitas.IMatcher<AnalyticEntity> _matcherVoodooGameLevelFinishEvent;

    public static Entitas.IMatcher<AnalyticEntity> VoodooGameLevelFinishEvent {
        get {
            if (_matcherVoodooGameLevelFinishEvent == null) {
                var matcher = (Entitas.Matcher<AnalyticEntity>)Entitas.Matcher<AnalyticEntity>.AllOf(AnalyticComponentsLookup.VoodooGameLevelFinishEvent);
                matcher.componentNames = AnalyticComponentsLookup.componentNames;
                _matcherVoodooGameLevelFinishEvent = matcher;
            }

            return _matcherVoodooGameLevelFinishEvent;
        }
    }
}
