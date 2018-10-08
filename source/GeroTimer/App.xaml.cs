using System;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Unity.Windows;
using Windows.ApplicationModel.Activation;

namespace GeroTimer
{
	/// <summary>
	/// 既定の Application クラスを補完するアプリケーション固有の動作を提供します。
	/// </summary>
	sealed partial class App : PrismUnityApplication
	{
		/// <summary>
		/// 単一アプリケーション オブジェクトを初期化します。これは、実行される作成したコードの
		///最初の行であるため、main() または WinMain() と論理的に等価です。
		/// </summary>
		public App()
		{
			this.InitializeComponent();
		}

		protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
		{
			this.NavigationService.Navigate("Main", null);
			return Task.CompletedTask;
		}

		protected override Type GetPageType(string pageToken)
		{
			return Type.GetType($"GeroTimer.Views.{pageToken}Page, GeroTimer.{pageToken}Page");
		}

		protected override void ConfigureViewModelLocator()
		{
			base.ConfigureViewModelLocator();
			ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver(viewType =>
			{
				var template = "GeroTimer.ViewModels.{0}ViewModel,GeroTimer.{0}";
				var typeFullName = string.Format(template, viewType.Name);
				return Type.GetType(typeFullName);
			});

		}
	}
}
