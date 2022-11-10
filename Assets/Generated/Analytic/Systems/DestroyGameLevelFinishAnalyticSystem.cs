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

public sealed class DestroyGameLevelFinishAnalyticSystem : ICleanupSystem {

    readonly IGroup<AnalyticEntity> _group;
    readonly List<AnalyticEntity> _buffer = new List<AnalyticEntity>();

    public DestroyGameLevelFinishAnalyticSystem(Contexts contexts) {
        _group = contexts.analytic.GetGroup(AnalyticMatcher.GameLevelFinish);
    }

    public void Cleanup() {
        foreach (var e in _group.GetEntities(_buffer)) {
            e.Destroy();
        }
    }
}