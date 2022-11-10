using Core.UI;
using Entitas;
using TMPro;
using UnityEngine;

namespace UI
{
    public class UIPlayerTryCountView : UIElement, IUIPlayerTryCountListener, IUIElementHideListener,IUIElementShowListener
    {
        [SerializeField] private TextMeshProUGUI tyrCountField;
        public override void Init(IEntity iEntity)
        {
            base.Init(iEntity);
            UIEntity.isPlayerTryCounter = true;
            UIEntity.AddUIPlayerTryCountListener(this);
            UIEntity.AddUIElementHideListener(this);
            UIEntity.AddUIElementShowListener(this);
            UIEntity.isUIElementHide = true;
        }
        public void OnUIPlayerTryCount(UiEntity entity, int value)
        {
            tyrCountField.text = $"Lives: " + value.ToString();
        }

        public void OnUIElementHide(UiEntity entity)
        {
            gameObject.SetActive(false);
        }

        public void OnUIElementShow(UiEntity entity)
        {
            gameObject.SetActive(true);
        }
    }
}