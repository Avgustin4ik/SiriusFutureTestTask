//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class AudioEntity {

    public Core.Audio.SideMusicChannelIndexComponent sideMusicChannelIndex { get { return (Core.Audio.SideMusicChannelIndexComponent)GetComponent(AudioComponentsLookup.SideMusicChannelIndex); } }
    public bool hasSideMusicChannelIndex { get { return HasComponent(AudioComponentsLookup.SideMusicChannelIndex); } }

    public void AddSideMusicChannelIndex(int newValue) {
        var index = AudioComponentsLookup.SideMusicChannelIndex;
        var component = (Core.Audio.SideMusicChannelIndexComponent)CreateComponent(index, typeof(Core.Audio.SideMusicChannelIndexComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSideMusicChannelIndex(int newValue) {
        var index = AudioComponentsLookup.SideMusicChannelIndex;
        var component = (Core.Audio.SideMusicChannelIndexComponent)CreateComponent(index, typeof(Core.Audio.SideMusicChannelIndexComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSideMusicChannelIndex() {
        RemoveComponent(AudioComponentsLookup.SideMusicChannelIndex);
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

    static Entitas.IMatcher<AudioEntity> _matcherSideMusicChannelIndex;

    public static Entitas.IMatcher<AudioEntity> SideMusicChannelIndex {
        get {
            if (_matcherSideMusicChannelIndex == null) {
                var matcher = (Entitas.Matcher<AudioEntity>)Entitas.Matcher<AudioEntity>.AllOf(AudioComponentsLookup.SideMusicChannelIndex);
                matcher.componentNames = AudioComponentsLookup.componentNames;
                _matcherSideMusicChannelIndex = matcher;
            }

            return _matcherSideMusicChannelIndex;
        }
    }
}
