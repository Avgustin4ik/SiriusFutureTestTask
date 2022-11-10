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

public sealed class DestroyRequestPlayMainTrackMusicAudioSystem : ICleanupSystem {

    readonly IGroup<AudioEntity> _group;
    readonly List<AudioEntity> _buffer = new List<AudioEntity>();

    public DestroyRequestPlayMainTrackMusicAudioSystem(Contexts contexts) {
        _group = contexts.audio.GetGroup(AudioMatcher.RequestPlayMainTrackMusic);
    }

    public void Cleanup() {
        foreach (var e in _group.GetEntities(_buffer)) {
            e.Destroy();
        }
    }
}
