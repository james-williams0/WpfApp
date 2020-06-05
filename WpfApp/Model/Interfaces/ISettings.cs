using WpfApp.ViewModel.Enum;

namespace WpfApp.Model.Interfaces
{
   public interface ISettings
   {
      StoredTheme WindowTheme { get; set; }

      int Language { get; set; }

      public void Save();

      public void Load();
   }
}
