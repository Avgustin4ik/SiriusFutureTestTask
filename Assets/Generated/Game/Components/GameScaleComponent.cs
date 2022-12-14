//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Core.Common.ScaleComponent scale { get { return (Core.Common.ScaleComponent)GetComponent(GameComponentsLookup.Scale); } }
    public bool hasScale { get { return HasComponent(GameComponentsLookup.Scale); } }

    public void AddScale(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.Scale;
        var component = (Core.Common.ScaleComponent)CreateComponent(index, typeof(Core.Common.ScaleComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceScale(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.Scale;
        var component = (Core.Common.ScaleComponent)CreateComponent(index, typeof(Core.Common.ScaleComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveScale() {
        RemoveComponent(GameComponentsLookup.Scale);
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

    static Entitas.IMatcher<GameEntity> _matcherScale;

    public static Entitas.IMatcher<GameEntity> Scale {
        get {
            if (_matcherScale == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Scale);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherScale = matcher;
            }

            return _matcherScale;
        }
    }
}
