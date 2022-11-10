//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class AnalyticEntity {

    static readonly Core.Analytics.GameLevelFinishComponent gameLevelFinishComponent = new Core.Analytics.GameLevelFinishComponent();

    public bool isGameLevelFinish {
        get { return HasComponent(AnalyticComponentsLookup.GameLevelFinish); }
        set {
            if (value != isGameLevelFinish) {
                var index = AnalyticComponentsLookup.GameLevelFinish;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : gameLevelFinishComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<AnalyticEntity> _matcherGameLevelFinish;

    public static Entitas.IMatcher<AnalyticEntity> GameLevelFinish {
        get {
            if (_matcherGameLevelFinish == null) {
                var matcher = (Entitas.Matcher<AnalyticEntity>)Entitas.Matcher<AnalyticEntity>.AllOf(AnalyticComponentsLookup.GameLevelFinish);
                matcher.componentNames = AnalyticComponentsLookup.componentNames;
                _matcherGameLevelFinish = matcher;
            }

            return _matcherGameLevelFinish;
        }
    }
}