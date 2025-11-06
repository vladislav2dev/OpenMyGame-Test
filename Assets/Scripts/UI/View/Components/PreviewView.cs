using UnityEngine;
using UnityEngine.UI;

namespace UI.View.Components
{
    public class PreviewView : View
    {
        [field:SerializeField] public Image Background { get; private set; }
        [field:SerializeField] public Image CloseIcon { get; private set; }
    }
}
