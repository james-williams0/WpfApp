using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WpfApp.Model;
using WpfApp.Model.Interfaces;
using WpfApp.ViewModel.Enum;
using WpfApp.ViewModel.Helper;
using WpfApp.ViewModel.Interfaces;

namespace WpfApp.ViewModel
{
   public class SettingsViewModel : OnPropertyChangedImplementation, INavigatable
   {
      public StoredTheme CurrentTheme
      {
         get { return currentTheme; }
         set
         {
            currentTheme = value;
            OnPropertyChanged();
            SetBaseColour();
         }
      }

      public ObservableCollection<StoredTheme> Themes
      {
         get { return themes; }
         set
         {
            themes = value;
            OnPropertyChanged();
         }
      }

      public void OnNavigateAway()
      {
      }

      public void OnNavigateTo()
      {
         currentTheme = globalSettings.WindowTheme;
      }

      public SettingsViewModel(ISettings settings)
      {
         Themes = new ObservableCollection<StoredTheme> { StoredTheme.Dark , StoredTheme.Light };
         globalSettings = settings;
      }

      private void SetBaseColour()
      {
         ThemeSetter.SetBaseColour(CurrentTheme.AsBaseTheme());
         globalSettings.WindowTheme = CurrentTheme;
         globalSettings.Save();
      }

      private StoredTheme currentTheme;
      private ISettings globalSettings;
      private ObservableCollection<StoredTheme> themes;
   }
}
