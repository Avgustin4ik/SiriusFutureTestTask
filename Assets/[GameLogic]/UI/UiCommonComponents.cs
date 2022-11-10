using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace UI
{
    [Ui]
    public sealed class PlayerTryCounterComponent : IComponent
    {
    }
    
    [Ui]
    public sealed class LetterBoxPanelComponent : IComponent
    {
    }

    [Ui]
    public sealed class LetterBoxRiddlePanelComponent : IComponent
    {
    }

    [Ui]
    public sealed class LetterBoxKeyPanelComponent : IComponent
    {
    }
    [Ui]
    public sealed class LetterBoxComponent : IComponent
    {
    }

    [Game]
    public sealed class LetterBoxOpenComponent : IComponent
    {
        
    }

    [Game]
    public sealed class LetterBoxFailComponent : IComponent
    {
        
    }

    [Ui,Event(EventTarget.Self), Cleanup(CleanupMode.RemoveComponent)]
    public sealed class UIElementShowComponent : IComponent
    {
        
    }

    [Ui,Event(EventTarget.Self), Cleanup(CleanupMode.RemoveComponent)]
    public sealed class UIElementHideComponent : IComponent
    {
        
    }

    [Ui, Event(EventTarget.Self)]
    public sealed class UIPlayerTryCountComponent : IComponent
    {
        public int value;
    }
    [Game, Event(EventTarget.Self)]
    public sealed class PlayerTryCountComponent : IComponent
    {
        public int value;
    }

    [Ui, Cleanup(CleanupMode.RemoveComponent)]
    public sealed class LetterBoxClickedComponent : IComponent
    {
    }

    [Ui,Event(EventTarget.Self), Cleanup(CleanupMode.RemoveComponent)]
    public sealed class ClickedComponent : IComponent
    {
    }

    [Ui, Event(EventTarget.Self)]
    public sealed class LetterLabelComponent : IComponent
    {
        public char value;
    }

    [Ui, Event(EventTarget.Self)]
    public sealed class LetterLabelHideComponent : IComponent
    {
        public bool value;
    }

    [Ui]
    public sealed class LetterGuessComponent : IComponent
    {
    }

    [Ui]
    public sealed class LetterKeyComponent : IComponent
    {
    }
    
}