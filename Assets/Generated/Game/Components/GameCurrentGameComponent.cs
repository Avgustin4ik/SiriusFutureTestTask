//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity currentGameEntity { get { return GetGroup(GameMatcher.CurrentGame).GetSingleEntity(); } }

    public bool isStaticCurrentGame {
        get { return currentGameEntity != null; }
        set {
            var entity = currentGameEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isStaticCurrentGame = true;
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

    static readonly Core.Common.CurrentGameComponent currentGameComponent = new Core.Common.CurrentGameComponent();

    public bool isStaticCurrentGame {
        get { return HasComponent(GameComponentsLookup.CurrentGame); }
        set {
            if (value != isStaticCurrentGame) {
                var index = GameComponentsLookup.CurrentGame;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : currentGameComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherCurrentGame;

    public static Entitas.IMatcher<GameEntity> CurrentGame {
        get {
            if (_matcherCurrentGame == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CurrentGame);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCurrentGame = matcher;
            }

            return _matcherCurrentGame;
        }
    }
}
