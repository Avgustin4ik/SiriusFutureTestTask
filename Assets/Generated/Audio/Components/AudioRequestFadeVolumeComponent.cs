//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class AudioEntity {

    public Core.Audio.RequestFadeVolumeComponent requestFadeVolume { get { return (Core.Audio.RequestFadeVolumeComponent)GetComponent(AudioComponentsLookup.RequestFadeVolume); } }
    public bool hasRequestFadeVolume { get { return HasComponent(AudioComponentsLookup.RequestFadeVolume); } }

    public void AddRequestFadeVolume(float newFadeTime, float newValue) {
        var index = AudioComponentsLookup.RequestFadeVolume;
        var component = (Core.Audio.RequestFadeVolumeComponent)CreateComponent(index, typeof(Core.Audio.RequestFadeVolumeComponent));
        component.fadeTime = newFadeTime;
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceRequestFadeVolume(float newFadeTime, float newValue) {
        var index = AudioComponentsLookup.RequestFadeVolume;
        var component = (Core.Audio.RequestFadeVolumeComponent)CreateComponent(index, typeof(Core.Audio.RequestFadeVolumeComponent));
        component.fadeTime = newFadeTime;
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveRequestFadeVolume() {
        RemoveComponent(AudioComponentsLookup.RequestFadeVolume);
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

    static Entitas.IMatcher<AudioEntity> _matcherRequestFadeVolume;

    public static Entitas.IMatcher<AudioEntity> RequestFadeVolume {
        get {
            if (_matcherRequestFadeVolume == null) {
                var matcher = (Entitas.Matcher<AudioEntity>)Entitas.Matcher<AudioEntity>.AllOf(AudioComponentsLookup.RequestFadeVolume);
                matcher.componentNames = AudioComponentsLookup.componentNames;
                _matcherRequestFadeVolume = matcher;
            }

            return _matcherRequestFadeVolume;
        }
    }
}