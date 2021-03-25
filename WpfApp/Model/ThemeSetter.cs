using MaterialDesignThemes.Wpf;

namespace WpfApp.Model
{
	public static class ThemeSetter
	{
		public static void SetApplicationTheme(IBaseTheme baseTheme)
		{
			PaletteHelper _paletteHelper = new PaletteHelper();
			ITheme theme = _paletteHelper.GetTheme();
			theme.SetBaseTheme(baseTheme);
			_paletteHelper.SetTheme(theme);
		}
	}
}
