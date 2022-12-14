//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity currentGameLevelEntity { get { return GetGroup(GameMatcher.CurrentGameLevel).GetSingleEntity(); } }

    public bool isStaticCurrentGameLevel {
        get { return currentGameLevelEntity != null; }
        set {
            var entity = currentGameLevelEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isStaticCurrentGameLevel = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Core.GameLevels.CurrentGameLevelComponent currentGameLevelComponent = new Core.GameLevels.CurrentGameLevelComponent();

    public bool isStaticCurrentGameLevel {
        get { return HasComponent(GameComponentsLookup.CurrentGameLevel); }
        set {
            if (value != isStaticCurrentGameLevel) {
                var index = GameComponentsLookup.CurrentGameLevel;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : currentGameLevelComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherCurrentGameLevel;

    public static Entitas.IMatcher<GameEntity> CurrentGameLevel {
        get {
            if (_matcherCurrentGameLevel == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CurrentGameLevel);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCurrentGameLevel = matcher;
            }

            return _matcherCurrentGameLevel;
        }
    }
}
