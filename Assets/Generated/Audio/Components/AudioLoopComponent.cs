//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class AudioEntity {

    static readonly Core.Audio.LoopComponent loopComponent = new Core.Audio.LoopComponent();

    public bool isLoop {
        get { return HasComponent(AudioComponentsLookup.Loop); }
        set {
            if (value != isLoop) {
                var index = AudioComponentsLookup.Loop;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : loopComponent;

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
public sealed partial class AudioMatcher {

    static Entitas.IMatcher<AudioEntity> _matcherLoop;

    public static Entitas.IMatcher<AudioEntity> Loop {
        get {
            if (_matcherLoop == null) {
                var matcher = (Entitas.Matcher<AudioEntity>)Entitas.Matcher<AudioEntity>.AllOf(AudioComponentsLookup.Loop);
                matcher.componentNames = AudioComponentsLookup.componentNames;
                _matcherLoop = matcher;
            }

            return _matcherLoop;
        }
    }
}