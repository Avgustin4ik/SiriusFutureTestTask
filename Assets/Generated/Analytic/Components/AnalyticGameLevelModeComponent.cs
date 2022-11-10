//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class AnalyticEntity {

    public Core.Analytics.GameLevelModeComponent gameLevelMode { get { return (Core.Analytics.GameLevelModeComponent)GetComponent(AnalyticComponentsLookup.GameLevelMode); } }
    public bool hasGameLevelMode { get { return HasComponent(AnalyticComponentsLookup.GameLevelMode); } }

    public void AddGameLevelMode(string newValue) {
        var index = AnalyticComponentsLookup.GameLevelMode;
        var component = (Core.Analytics.GameLevelModeComponent)CreateComponent(index, typeof(Core.Analytics.GameLevelModeComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGameLevelMode(string newValue) {
        var index = AnalyticComponentsLookup.GameLevelMode;
        var component = (Core.Analytics.GameLevelModeComponent)CreateComponent(index, typeof(Core.Analytics.GameLevelModeComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGameLevelMode() {
        RemoveComponent(AnalyticComponentsLookup.GameLevelMode);
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

    static Entitas.IMatcher<AnalyticEntity> _matcherGameLevelMode;

    public static Entitas.IMatcher<AnalyticEntity> GameLevelMode {
        get {
            if (_matcherGameLevelMode == null) {
                var matcher = (Entitas.Matcher<AnalyticEntity>)Entitas.Matcher<AnalyticEntity>.AllOf(AnalyticComponentsLookup.GameLevelMode);
                matcher.componentNames = AnalyticComponentsLookup.componentNames;
                _matcherGameLevelMode = matcher;
            }

            return _matcherGameLevelMode;
        }
    }
}
