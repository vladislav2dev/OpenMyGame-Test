using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.View.Windows
{
    public class PreviewWindowView : global::UI.View.View
    {
        [field:SerializeField] public Button CloseButton { get; private set; }
        [field:SerializeField] public TextMeshProUGUI Title { get; private set; }
        [field:SerializeField] public Image ContentImage { get; private set; }
        [field:SerializeField] public Image ContentPattern { get; private set; }
        [field:SerializeField] public TextMeshProUGUI RewardText { get; private set; }
        [field:SerializeField] public RectTransform ButtonsTransform { get; private set; }
        [field:SerializeField] public Button PlayButton { get; private set; }
        [field:SerializeField] public TextMeshProUGUI PriceText { get; private set; }
    }
}
