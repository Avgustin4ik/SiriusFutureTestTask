//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.Roslyn.CodeGeneration.Plugins.CleanupSystemsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class InputCleanupSystems : Feature {

    public InputCleanupSystems(Contexts contexts) {
        Add(new DestroyButtonOpenStoreInputSystem(contexts));
        Add(new DestroyButtonOpenMainMenuInputSystem(contexts));
        Add(new DestroyButtonStartGameInputSystem(contexts));
        Add(new DestroyButtonRestartGameInputSystem(contexts));
        Add(new DestroyButtonCompleteGameInputSystem(contexts));
        Add(new DestroyButtonRestoreIapInputSystem(contexts));
        Add(new DestroyButtonNoAdsInputSystem(contexts));
        Add(new DestroyButtonGetSimpleStoreRandomItemByMoneyInputSystem(contexts));
        Add(new DestroyButtonGetMoneyRewardAtStoreInputSystem(contexts));
        Add(new DestroyButtonGetPremiumStoreRandomItemByAdsInputSystem(contexts));
        Add(new DestroyButtonGetXRewardCompleteLevelInputSystem(contexts));
        Add(new DestroyButtonGetRevivalLevelRewardInputSystem(contexts));
    }
}
