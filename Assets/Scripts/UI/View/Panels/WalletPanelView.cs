using TMPro;
using UnityEngine;

namespace UI.View.Panels
{
    public class WalletPanelView : PanelView
    {
        [field:SerializeField] public TextMeshProUGUI Wallet { get; private set; }
    }
}
