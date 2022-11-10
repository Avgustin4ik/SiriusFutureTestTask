//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class AnalyticEntity {

    public Core.Analytics.GameLevelLoopComponent gameLevelLoop { get { return (Core.Analytics.GameLevelLoopComponent)GetComponent(AnalyticComponentsLookup.GameLevelLoop); } }
    public bool hasGameLevelLoop { get { return HasComponent(AnalyticComponentsLookup.GameLevelLoop); } }

    public void AddGameLevelLoop(int newValue) {
        var index = AnalyticComponentsLookup.GameLevelLoop;
        var component = (Core.Analytics.GameLevelLoopComponent)CreateComponent(index, typeof(Core.Analytics.GameLevelLoopComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGameLevelLoop(int newValue) {
        var index = AnalyticComponentsLookup.GameLevelLoop;
        var component = (Core.Analytics.GameLevelLoopComponent)CreateComponent(index, typeof(Core.Analytics.GameLevelLoopComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGameLevelLoop() {
        RemoveComponent(AnalyticComponentsLookup.GameLevelLoop);
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

    static Entitas.IMatcher<AnalyticEntity> _matcherGameLevelLoop;

    public static Entitas.IMatcher<AnalyticEntity> GameLevelLoop {
        get {
            if (_matcherGameLevelLoop == null) {
                var matcher = (Entitas.Matcher<AnalyticEntity>)Entitas.Matcher<AnalyticEntity>.AllOf(AnalyticComponentsLookup.GameLevelLoop);
                matcher.componentNames = AnalyticComponentsLookup.componentNames;
                _matcherGameLevelLoop = matcher;
            }

            return _matcherGameLevelLoop;
        }
    }
}
