using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp.ViewModel.Interfaces
{
    public interface INavigatable
    {
        void OnNavigateTo();

        void OnNavigateAway();
    }
}
