using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using WpfApp.Model.Interfaces;
using WpfApp.ViewModel.Helper;
using WpfApp.ViewModel.Interfaces;

namespace WpfApp.ViewModel
{
   public class DataVisualiserViewModel : OnPropertyChangedImplementation, INavigatable
   {
      public DataVisualiserViewModel(ISettings settings)
      {
         globalSettings = settings;
      }

      public void OnNavigateAway()
      {       
      }

      public void OnNavigateTo()
      {
      }
      private ISettings globalSettings;
   }
}
