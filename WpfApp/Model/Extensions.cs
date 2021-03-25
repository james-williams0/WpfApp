using MaterialDesignThemes.Wpf;
using WpfApp.ViewModel.Enum;

namespace WpfApp.Model
{
	public static class Extensions
	{
		public static IBaseTheme AsBaseTheme(this StoredTheme theme)
		{
			IBaseTheme baseTheme = Theme.Dark;
			if(theme == StoredTheme.Light)
			{
				baseTheme = Theme.Light;
			}
			return baseTheme;
		}
	}
}
