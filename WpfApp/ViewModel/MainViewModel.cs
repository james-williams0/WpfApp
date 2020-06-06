using MaterialDesignThemes.Wpf;
using System;
using System.Diagnostics;
using System.Windows.Input;
using WpfApp.Model;
using WpfApp.ViewModel.Helper;
using WpfApp.ViewModel.Interfaces;

namespace WpfApp.ViewModel
{
    public class MainViewModel : OnPropertyChangedImplementation
    {
        private TestingGroundFactory Factory { get; set; } = new TestingGroundFactory();

        public INavigatable CurrentView
        {
            get { return currentView; }
            set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }

        public SettingsViewModel SettingsView
        {
            get { return settingsView; }
            set
            {
                settingsView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            CurrentView = Factory.CreateNotepadVM();
            ThemeSetter.SetApplicationTheme(Factory.SettingsStorage.WindowTheme.AsBaseTheme());
            SettingsView = Factory.CreateSettingsVM();
        }

        public ICommand NavigateToVisualiser
        {
            get { return new RelayCommand<object>(p => VisualiserNavigate()); }
        }

        public ICommand NavigateToHome
        {
            get { return new RelayCommand<object>(p => HomeNavigate()); }
        }

        public void HomeNavigate()
        {
            CurrentView.OnNavigateAway();
            CurrentView = Factory.CreateNotepadVM();
            CurrentView.OnNavigateTo();
        }

        public void VisualiserNavigate()
        {
            CurrentView.OnNavigateAway();
            CurrentView = Factory.CreateDataVisualiserVM();
            CurrentView.OnNavigateTo();
        }

        private INavigatable currentView;
        private SettingsViewModel settingsView;
    }
}
