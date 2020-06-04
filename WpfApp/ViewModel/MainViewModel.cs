using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using WpfApp.Model;
using WpfApp.ViewModel.Helper;
using WpfApp.ViewModel.Interfaces;

namespace WpfApp.ViewModel
{
   public class MainViewModel : OnPropertyChangedImplementation
   {
      public TestingGroundFactory Factory { get; set; } = new TestingGroundFactory();

      private INavigatable currentView;
      private IBaseTheme theme;

      public INavigatable CurrentView
      {
         get { return currentView; }
         set
         {
            currentView = value;
            OnPropertyChanged();
         }
      }

      public IBaseTheme WindowTheme
      {
         get { return theme; }
         set { theme = value; OnPropertyChanged(); }
      }
      public MainViewModel()
      {
         WindowTheme = Theme.Dark;
         CurrentView = Factory.Notepad;
      }
      public ICommand NavigateToVisualiser
      {
         get { return new RelayCommand<object>(p => VisualiserNavigate()); }
      }

      public void VisualiserNavigate()
      {
         CurrentView = Factory.DataVisualiser;
      }

      public ICommand NavigateToHome
      {
         get { return new RelayCommand<object>(p => HomeNavigate()); }
      }

      public void HomeNavigate()
      {
         CurrentView = Factory.Notepad;
      }
   }
}
