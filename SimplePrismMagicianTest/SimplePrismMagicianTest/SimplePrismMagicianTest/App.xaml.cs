using Prism;
using Prism.Ioc;
using Prism.Magician;
using SimplePrismMagicianTest.ViewModels;
using SimplePrismMagicianTest.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace SimplePrismMagicianTest
{
    [AutoRegisterViews]
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

        }
    }
}
