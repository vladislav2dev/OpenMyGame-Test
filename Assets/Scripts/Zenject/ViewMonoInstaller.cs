using UI.View.Panels;
using UI.View.Windows;

namespace Zenject
{
    public class ViewMonoInstaller : MonoInstaller
    {
        public DialogWindowView dialogWindowView;
        public HomeWindowView homeWindowView;
        public PreviewWindowView previewWindowView;
        public WalletPanelView walletPanelView;

        public override void InstallBindings()
        {
            BindView(dialogWindowView);
            BindView(homeWindowView);
            BindView(previewWindowView);
            BindView(walletPanelView);
        }

        private void BindView<T>(T instance)
        {
            Container
                .Bind<T>()
                .FromInstance(instance)
                .AsTransient()
                .NonLazy();
        }
    }
}