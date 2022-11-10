namespace Core.Input
{
    public sealed class InputGroupSystems : Entitas.Systems
    {
        public InputGroupSystems(Contexts contexts)
        {
            Add(new UIButtonsInputSystems(contexts.input, contexts.level, contexts.state));
        }
    }
}