//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public GameCamera.VirtualCameraIndexComponent virtualCameraIndex { get { return (GameCamera.VirtualCameraIndexComponent)GetComponent(GameComponentsLookup.VirtualCameraIndex); } }
    public bool hasVirtualCameraIndex { get { return HasComponent(GameComponentsLookup.VirtualCameraIndex); } }

    public void AddVirtualCameraIndex(int newValue) {
        var index = GameComponentsLookup.VirtualCameraIndex;
        var component = (GameCamera.VirtualCameraIndexComponent)CreateComponent(index, typeof(GameCamera.VirtualCameraIndexComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceVirtualCameraIndex(int newValue) {
        var index = GameComponentsLookup.VirtualCameraIndex;
        var component = (GameCamera.VirtualCameraIndexComponent)CreateComponent(index, typeof(GameCamera.VirtualCameraIndexComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveVirtualCameraIndex() {
        RemoveComponent(GameComponentsLookup.VirtualCameraIndex);
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

    static Entitas.IMatcher<GameEntity> _matcherVirtualCameraIndex;

    public static Entitas.IMatcher<GameEntity> VirtualCameraIndex {
        get {
            if (_matcherVirtualCameraIndex == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.VirtualCameraIndex);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherVirtualCameraIndex = matcher;
            }

            return _matcherVirtualCameraIndex;
        }
    }
}
