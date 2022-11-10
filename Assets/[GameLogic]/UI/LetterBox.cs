using Core.UI;
using Entitas;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
    public class LetterBox : UIElement, ILetterLabelHideListener, ILetterLabelListener, IPointerClickHandler
    {
        [SerializeField] private TMP_Text _label;
        public override void Init(IEntity iEntity)
        {
            base.Init(iEntity);
            UIEntity.isLetterBox = true;
            UIEntity.AddLetterLabelHideListener(this);
            UIEntity.AddLetterLabelListener(this);
            UIEntity.AddLetterLabel('x');
        }

        public void OnLetterLabelHide(UiEntity entity, bool value)
        {
            _label.enabled = !value;
        }

        public void OnLetterLabel(UiEntity entity, char value)
        {
            _label.text = value.ToString().ToUpper();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            UIEntity.isLetterBoxClicked = true;
        }
    }
}