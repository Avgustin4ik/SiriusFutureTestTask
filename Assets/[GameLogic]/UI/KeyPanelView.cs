using Core.UI;
using Entitas;

namespace UI
{
    public class KeyPanelView : UIElement
    {
        public override void Init(IEntity iEntity)
        {
            base.Init(iEntity);
            UIEntity.isLetterBoxPanel = true;
            UIEntity.isLetterBoxKeyPanel = true;
        }
    }
}