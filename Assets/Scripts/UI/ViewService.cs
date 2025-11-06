using System.Collections.Generic;
using System.Linq;
using UI.View;
using UnityEngine;
using Zenject;

namespace UI
{
    public class ViewService
    {
        private DiContainer _container;
        private List<WindowView> _windows = new();
        private RectTransform _windowsParent;
        private List<PanelView> _panels = new();
        private RectTransform _panelsParent;

        public T Window<T>() where T : WindowView
        {
            var window = _windows.FirstOrDefault(window => window is T);

            if (window == null)
                window = _container.InstantiatePrefabForComponent<T>();
            
            return window as T;
        }

        public void ShowWindow<T>() where T : WindowView
        {
            _windows.ForEach(window => window.Hide());
            Window<T>().Show();
        }

        public void HideWindow<T>() where T : WindowView
        {
            Window<T>().Hide();
        }

        public T Panel<T>() where T : PanelView
        {
            var panel = _panels.FirstOrDefault(panel => panel is T);

            if (panel == null)
                panel = null;
            
            return panel as T;
        }
        
        public void ShowPanel<T>() where T : PanelView
        {
            Panel<T>().Show();
        }
        
        public void HidePanel<T>() where T : PanelView
        {
            Panel<T>().Hide();
        }
    }
}