//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Core.UserData.UserDataGameLevelStartPlayTimeComponent userDataGameLevelStartPlayTime { get { return (Core.UserData.UserDataGameLevelStartPlayTimeComponent)GetComponent(GameComponentsLookup.UserDataGameLevelStartPlayTime); } }
    public bool hasUserDataGameLevelStartPlayTime { get { return HasComponent(GameComponentsLookup.UserDataGameLevelStartPlayTime); } }

    public void AddUserDataGameLevelStartPlayTime(System.DateTime newValue) {
        var index = GameComponentsLookup.UserDataGameLevelStartPlayTime;
        var component = (Core.UserData.UserDataGameLevelStartPlayTimeComponent)CreateComponent(index, typeof(Core.UserData.UserDataGameLevelStartPlayTimeComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceUserDataGameLevelStartPlayTime(System.DateTime newValue) {
        var index = GameComponentsLookup.UserDataGameLevelStartPlayTime;
        var component = (Core.UserData.UserDataGameLevelStartPlayTimeComponent)CreateComponent(index, typeof(Core.UserData.UserDataGameLevelStartPlayTimeComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveUserDataGameLevelStartPlayTime() {
        RemoveComponent(GameComponentsLookup.UserDataGameLevelStartPlayTime);
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

    static Entitas.IMatcher<GameEntity> _matcherUserDataGameLevelStartPlayTime;

    public static Entitas.IMatcher<GameEntity> UserDataGameLevelStartPlayTime {
        get {
            if (_matcherUserDataGameLevelStartPlayTime == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.UserDataGameLevelStartPlayTime);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherUserDataGameLevelStartPlayTime = matcher;
            }

            return _matcherUserDataGameLevelStartPlayTime;
        }
    }
}
