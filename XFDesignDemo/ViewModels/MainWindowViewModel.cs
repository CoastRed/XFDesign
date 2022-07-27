using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace XFDesignDemo.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager regionManager;

        private string _title = "XFDesignDemo";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        #region 命令

        /// <summary>
        /// 导航命令
        /// </summary>
        public DelegateCommand<string> NavigateCommand
        {
            get
            {
                return new DelegateCommand<string>(viewName =>
                {
                    this.regionManager.Regions["MainContentRegion"].RequestNavigate(viewName);
                });
            }
        }

        #endregion
    }
}
