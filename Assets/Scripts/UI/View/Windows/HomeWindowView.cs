using UnityEngine;
using UnityEngine.UI;

namespace UI.View.Windows
{
    public class HomeWindowView : global::UI.View.View
    {
        [field:SerializeField] public ScrollRect CategoriesScroll { get; private set; }
        [field:SerializeField] public ScrollRect PreviewsScroll { get; private set; }
    }
}
