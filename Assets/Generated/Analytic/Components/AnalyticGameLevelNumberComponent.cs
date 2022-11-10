//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class AnalyticEntity {

    public Core.Analytics.GameLevelNumberComponent gameLevelNumber { get { return (Core.Analytics.GameLevelNumberComponent)GetComponent(AnalyticComponentsLookup.GameLevelNumber); } }
    public bool hasGameLevelNumber { get { return HasComponent(AnalyticComponentsLookup.GameLevelNumber); } }

    public void AddGameLevelNumber(int newValue) {
        var index = AnalyticComponentsLookup.GameLevelNumber;
        var component = (Core.Analytics.GameLevelNumberComponent)CreateComponent(index, typeof(Core.Analytics.GameLevelNumberComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGameLevelNumber(int newValue) {
        var index = AnalyticComponentsLookup.GameLevelNumber;
        var component = (Core.Analytics.GameLevelNumberComponent)CreateComponent(index, typeof(Core.Analytics.GameLevelNumberComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGameLevelNumber() {
        RemoveComponent(AnalyticComponentsLookup.GameLevelNumber);
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

    static Entitas.IMatcher<AnalyticEntity> _matcherGameLevelNumber;

    public static Entitas.IMatcher<AnalyticEntity> GameLevelNumber {
        get {
            if (_matcherGameLevelNumber == null) {
                var matcher = (Entitas.Matcher<AnalyticEntity>)Entitas.Matcher<AnalyticEntity>.AllOf(AnalyticComponentsLookup.GameLevelNumber);
                matcher.componentNames = AnalyticComponentsLookup.componentNames;
                _matcherGameLevelNumber = matcher;
            }

            return _matcherGameLevelNumber;
        }
    }
}