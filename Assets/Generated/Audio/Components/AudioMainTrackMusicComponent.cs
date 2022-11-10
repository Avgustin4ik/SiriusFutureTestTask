//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class AudioEntity {

    static readonly Core.Audio.MainTrackMusicComponent mainTrackMusicComponent = new Core.Audio.MainTrackMusicComponent();

    public bool isMainTrackMusic {
        get { return HasComponent(AudioComponentsLookup.MainTrackMusic); }
        set {
            if (value != isMainTrackMusic) {
                var index = AudioComponentsLookup.MainTrackMusic;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : mainTrackMusicComponent;

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

    static Entitas.IMatcher<AudioEntity> _matcherMainTrackMusic;

    public static Entitas.IMatcher<AudioEntity> MainTrackMusic {
        get {
            if (_matcherMainTrackMusic == null) {
                var matcher = (Entitas.Matcher<AudioEntity>)Entitas.Matcher<AudioEntity>.AllOf(AudioComponentsLookup.MainTrackMusic);
                matcher.componentNames = AudioComponentsLookup.componentNames;
                _matcherMainTrackMusic = matcher;
            }

            return _matcherMainTrackMusic;
        }
    }
}
