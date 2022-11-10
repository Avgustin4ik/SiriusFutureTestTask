//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Core.GameLevels.GameLevelCleanupComponent gameLevelCleanupComponent = new Core.GameLevels.GameLevelCleanupComponent();

    public bool isGameLevelCleanup {
        get { return HasComponent(GameComponentsLookup.GameLevelCleanup); }
        set {
            if (value != isGameLevelCleanup) {
                var index = GameComponentsLookup.GameLevelCleanup;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : gameLevelCleanupComponent;

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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherGameLevelCleanup;

    public static Entitas.IMatcher<GameEntity> GameLevelCleanup {
        get {
            if (_matcherGameLevelCleanup == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameLevelCleanup);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameLevelCleanup = matcher;
            }

            return _matcherGameLevelCleanup;
        }
    }
}
