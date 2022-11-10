//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Game.RiddleWordComponent riddleWord { get { return (Game.RiddleWordComponent)GetComponent(GameComponentsLookup.RiddleWord); } }
    public bool hasRiddleWord { get { return HasComponent(GameComponentsLookup.RiddleWord); } }

    public void AddRiddleWord(string newValue) {
        var index = GameComponentsLookup.RiddleWord;
        var component = (Game.RiddleWordComponent)CreateComponent(index, typeof(Game.RiddleWordComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceRiddleWord(string newValue) {
        var index = GameComponentsLookup.RiddleWord;
        var component = (Game.RiddleWordComponent)CreateComponent(index, typeof(Game.RiddleWordComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveRiddleWord() {
        RemoveComponent(GameComponentsLookup.RiddleWord);
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

    static Entitas.IMatcher<GameEntity> _matcherRiddleWord;

    public static Entitas.IMatcher<GameEntity> RiddleWord {
        get {
            if (_matcherRiddleWord == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.RiddleWord);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherRiddleWord = matcher;
            }

            return _matcherRiddleWord;
        }
    }
}