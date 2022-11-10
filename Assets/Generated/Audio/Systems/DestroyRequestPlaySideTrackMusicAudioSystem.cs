//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.Roslyn.CodeGeneration.Plugins.CleanupSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Collections.Generic;
using Entitas;

public sealed class DestroyRequestPlaySideTrackMusicAudioSystem : ICleanupSystem {

    readonly IGroup<AudioEntity> _group;
    readonly List<AudioEntity> _buffer = new List<AudioEntity>();

    public DestroyRequestPlaySideTrackMusicAudioSystem(Contexts contexts) {
        _group = contexts.audio.GetGroup(AudioMatcher.RequestPlaySideTrackMusic);
    }

    public void Cleanup() {
        foreach (var e in _group.GetEntities(_buffer)) {
            e.Destroy();
        }
    }
}
