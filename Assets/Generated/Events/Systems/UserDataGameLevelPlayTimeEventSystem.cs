//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class UserDataGameLevelPlayTimeEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IUserDataGameLevelPlayTimeListener> _listenerBuffer;

    public UserDataGameLevelPlayTimeEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IUserDataGameLevelPlayTimeListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.UserDataGameLevelPlayTime)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasUserDataGameLevelPlayTime && entity.hasUserDataGameLevelPlayTimeListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.userDataGameLevelPlayTime;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.userDataGameLevelPlayTimeListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnUserDataGameLevelPlayTime(e, component.value);
            }
        }
    }
}
