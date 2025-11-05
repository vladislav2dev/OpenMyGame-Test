using System;
using UnityEngine.UI;

namespace Extensions
{
    public static class ButtonExtensions
    {
        public static void SetListener(this Button button, Action onClickAction)
        {
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(() => onClickAction?.Invoke());
        }
    }
}