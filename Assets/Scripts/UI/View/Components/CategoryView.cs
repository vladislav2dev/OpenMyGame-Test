using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.View.Components
{
    public class CategoryView : global::UI.View.View
    {
        [field:SerializeField] public Button Button { get; private set; }
        [field:SerializeField] public TextMeshProUGUI Text { get; private set; }
    }
}
