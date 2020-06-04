using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using WpfApp.ViewModel.Helper;
using WpfApp.ViewModel.Interfaces;

namespace WpfApp.ViewModel
{
    public class DataVisualiserViewModel : OnPropertyChangedImplementation, INavigatable
    {

      private IBaseTheme windowTheme;

      public IBaseTheme WindowTheme
      {
         get { return windowTheme; }
         set { windowTheme = value; }
      }

      public void OnNavigateAway()
        {
            throw new NotImplementedException();
        }

        public void OnNavigateTo()
        {
            throw new NotImplementedException();
        }
    }
}
