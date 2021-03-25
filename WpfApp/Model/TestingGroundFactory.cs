using System.Windows.Controls;
using WpfApp.Model.Interfaces;
using WpfApp.ViewModel;

namespace WpfApp.Model
{
	public class TestingGroundFactory
	{
		public ISettings SettingsStorage { get; } 

		public TestingGroundFactory()
		{
			SettingsStorage = new Settings();
			SettingsStorage.Load();
			mainRTB = new RichTextBox();
		}

		public NotepadViewModel CreateNotepadVM()
		{
			return new NotepadViewModel(mainRTB, SettingsStorage);
		}

		public DataVisualiserViewModel CreateDataVisualiserVM()
		{
			return new DataVisualiserViewModel(SettingsStorage);
		}

		public SettingsViewModel CreateSettingsVM()
		{
			return new SettingsViewModel(SettingsStorage);
		}

		private RichTextBox mainRTB;
	}
}
