using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

using Prism.Ioc;
using Prism.DryIoc;
using Prism.Modularity;

using Rubik.Toolkit.Extensions;

using MindFlow.App.Views;
using MindFlow.Common.Models;
using MindFlow.Common.Dialogs;
using MindFlow.Common.ViewModels;
using Microsoft.Extensions.Configuration;

namespace MindFlow.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        public App() : base()
        {
            DispatcherUnhandledException += App_DispatcherUnhandledException;
            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        #region Exception

        private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            var msg = "[ UnhandledException ] UI Dispatcher, " + e.Exception.GetStringFormat();
            var time = " [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss,fff") + "]";

            //Logger.Instance.App.Error(msg);
            MessageBox.Show(msg, "Exception" + time, MessageBoxButton.OK, MessageBoxImage.Error);

            e.Handled = true;
        }

        private void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            var msg = "[ UnhandledException ] Task, " + e.Exception.Message;
            var time = " [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss,fff") + "]";

            //Logger.Instance.App.Error(msg);
            //MessageBox.Show(msg, "Exception" + time, MessageBoxButton.OK, MessageBoxImage.Error);

            e.SetObserved();
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var msg = "[ UnhandledException ] Current Domain, " + (e.ExceptionObject as Exception).GetStringFormat();
            var time = " [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss,fff") + "]";

            //Logger.Instance.App.Error(msg);
            MessageBox.Show(msg, "Exception" + time, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        #endregion

        /// <summary>
        /// Shell
        /// </summary>
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //Config
            var configuration = new ConfigurationBuilder().SetBasePath(ResourcesMap.LocationDic[Location.GlobalConfigPath]).AddJsonFile(ResourcesMap.LocationDic[Location.ConfigFileName]).Build();

            var localConfig = new GlobalConfig();
            configuration.Bind(localConfig);

            //var localConfig = FileUtil.LoadFromJsonFile<GlobalConfig>(ResourcesMap.LocationDic[Location.GlobalConfigFile]);

            //Version
            var version = ResourceAssembly.GetName().Version;
            var appData = new AppData
            {
                Version = $"{version.Major}.{version.Minor}.{version.Build}",
                Config = localConfig ?? new GlobalConfig()
            };

            //Logger.Instance.App.Info($"[ Version ] v{version.Major}.{version.Minor}.{version.Build}.{version.Revision}");

            //Settings
            containerRegistry.RegisterInstance(appData);

            //Dialog
            containerRegistry.RegisterDialogWindow<DialogWindow>();
            containerRegistry.RegisterDialog<MessageDialog, MessageDialogViewModel>();
        }

        /// <summary>
        /// Module Catalog
        /// </summary>
        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new DirectoryModuleCatalog() { ModulePath = ResourcesMap.LocationDic[Location.ModulePath] };
        }

        /// <summary>
        /// 初始化完成
        /// </summary>
        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
        }
}
