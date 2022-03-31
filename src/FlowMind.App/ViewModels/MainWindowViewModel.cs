using System.Windows;
using System.ComponentModel;

using Prism.Commands;
using Prism.Mvvm;
using Prism.Events;
using Prism.Services.Dialogs;

using Rubik.Toolkit.IO;

using FlowMind.Common.Models;
using FlowMind.Common.Events;
using FlowMind.Common.Extensions;

namespace FlowMind.App.ViewModels
{
    /// <summary>
    /// 主窗体 ViewModel
    /// </summary>
    public class MainWindowViewModel : BindableBase
    {
        private AppData _appData = null;
        private IDialogService _dialogService = null;
        private IEventAggregator _eventAggregator = null;

        //Command
        public DelegateCommand<RoutedEventArgs> LoadedCommand { get; private set; }
        public DelegateCommand<CancelEventArgs> ClosingCommand { get; private set; }

        public MainWindowViewModel(AppData appData, IDialogService dialogService, IEventAggregator eventAggregator)
        {
            _appData = appData;

            _dialogService = dialogService;
            _eventAggregator = eventAggregator;

            InitEvents();
            InitCommands();
        }

        #region Property

        /// <summary>
        /// 标题
        /// </summary>
        public string Title => "FlowMind";

        /// <summary>
        /// 版本
        /// </summary>
        public string Version => _appData.Version;

        private string _busyMessage = null;
        public string BusyMessage
        {
            get { return _busyMessage; }
            set { SetProperty(ref _busyMessage, value); }
        }

        #endregion

        #region Init

        private void InitEvents()
        {
            _eventAggregator.GetEvent<BusyMessageEvent>().Subscribe(OnBusyMessage);
        }

        private void InitCommands()
        {
            LoadedCommand = new DelegateCommand<RoutedEventArgs>(Loaded);
            ClosingCommand = new DelegateCommand<CancelEventArgs>(Closing);
        }

        #endregion

        #region Event

        private void OnBusyMessage(string msg)
        {
            BusyMessage = msg;
        }

        #endregion

        #region Command

        private void Loaded(RoutedEventArgs e)
        {
            //_sidebarStackPanel = (e.OriginalSource as MainWindow).SidebarStackPanel;
        }

        /// <summary>
        /// 关闭
        /// </summary>
        private void Closing(CancelEventArgs e)
        {
            var confirm = false;
            _dialogService.ShowMessage("确认关闭吗？", MessageButton.YesNo, MessageType.Question, r => confirm = r.Result == ButtonResult.Yes);

            if (!confirm)
            {
                e.Cancel = true;
                return;
            }

            if (_appData.Config != null)
                FileUtil.SaveToJsonFile(ResourcesMap.LocationDic[Location.GlobalConfigFile], _appData.Config);
        }

        #endregion
    }
}
