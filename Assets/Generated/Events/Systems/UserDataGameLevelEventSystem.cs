//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class UserDataGameLevelEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IUserDataGameLevelListener> _listenerBuffer;

    public UserDataGameLevelEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IUserDataGameLevelListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.UserDataGameLevel)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasUserDataGameLevel && entity.hasUserDataGameLevelListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.userDataGameLevel;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.userDataGameLevelListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnUserDataGameLevel(e, component.value);
            }
        }
    }
}
