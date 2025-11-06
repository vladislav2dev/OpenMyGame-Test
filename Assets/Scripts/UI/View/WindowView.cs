using UnityEngine;
using Zenject;

namespace UI.View
{
    public class WindowView : View
    {
        [Inject]
        public void Constructor(RectTransform parent)
        {
            transform.SetParent(parent);
        }
    }
}