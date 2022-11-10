//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class AudioEntity {

    public Core.Audio.SoundChannelIndexComponent soundChannelIndex { get { return (Core.Audio.SoundChannelIndexComponent)GetComponent(AudioComponentsLookup.SoundChannelIndex); } }
    public bool hasSoundChannelIndex { get { return HasComponent(AudioComponentsLookup.SoundChannelIndex); } }

    public void AddSoundChannelIndex(int newValue) {
        var index = AudioComponentsLookup.SoundChannelIndex;
        var component = (Core.Audio.SoundChannelIndexComponent)CreateComponent(index, typeof(Core.Audio.SoundChannelIndexComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSoundChannelIndex(int newValue) {
        var index = AudioComponentsLookup.SoundChannelIndex;
        var component = (Core.Audio.SoundChannelIndexComponent)CreateComponent(index, typeof(Core.Audio.SoundChannelIndexComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSoundChannelIndex() {
        RemoveComponent(AudioComponentsLookup.SoundChannelIndex);
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

    static Entitas.IMatcher<AudioEntity> _matcherSoundChannelIndex;

    public static Entitas.IMatcher<AudioEntity> SoundChannelIndex {
        get {
            if (_matcherSoundChannelIndex == null) {
                var matcher = (Entitas.Matcher<AudioEntity>)Entitas.Matcher<AudioEntity>.AllOf(AudioComponentsLookup.SoundChannelIndex);
                matcher.componentNames = AudioComponentsLookup.componentNames;
                _matcherSoundChannelIndex = matcher;
            }

            return _matcherSoundChannelIndex;
        }
    }
}
