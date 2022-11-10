using Core.Extension;
using Core.UI;
using Entitas;

namespace UI
{
    public class RiddlePanelView : UIElement
    {
        public override void Init(IEntity iEntity)
        {
            base.Init(iEntity);
            UIEntity.isLetterBoxPanel = true;
            UIEntity.isLetterBoxRiddlePanel = true;
        }
    }
}