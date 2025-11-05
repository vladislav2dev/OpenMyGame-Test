using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.View.Windows
{
    public class DialogWindowView : global::UI.View.View
    {
        [field:SerializeField] public TextMeshProUGUI Title { get; private set; }
        [field:SerializeField] public TextMeshProUGUI Description { get; private set; }
        [field:SerializeField] public Button CloseButton { get; private set; }
        [field:SerializeField] public Button AcceptButton { get; private set; }
    }
}
