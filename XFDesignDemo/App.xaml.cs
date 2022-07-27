using Prism.Ioc;
using System.Windows;
using XFDesignDemo.Views;
using XFDesignDemo.Views.BasicControls;
using XFDesignDemo.Views.DataDisplay;

namespace XFDesignDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<TextBoxView>();
            containerRegistry.RegisterForNavigation<ProgressBarView>();
            containerRegistry.RegisterForNavigation<TabControlView>();

            containerRegistry.RegisterForNavigation<DataGridView>();
        }
    }
}
