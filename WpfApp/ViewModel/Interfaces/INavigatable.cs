using MaterialDesignThemes.Wpf;

namespace WpfApp.ViewModel.Interfaces
{
	public interface INavigatable
	{
		void OnNavigateTo();

		void OnNavigateAway();
	}
}
