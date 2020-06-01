using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public bool Bold { get; set; } = false;

        public bool Underline { get; set; } = false;

        public bool Italic { get; set; } = false;

        private SolidColorBrush boldBackground = Brushes.LightGray;

        public SolidColorBrush BoldBackground
        {
            get { return boldBackground; }
            set
            {
                boldBackground = value;
                OnPropertyChanged();
            }
        }

        private SolidColorBrush underlineBackground = Brushes.LightGray;

        public SolidColorBrush UnderlineBackground
        {
            get { return underlineBackground; }
            set
            {
                underlineBackground = value;
                OnPropertyChanged();
            }
        }

        private SolidColorBrush italicBackground = Brushes.LightGray;

        public SolidColorBrush ItalicBackground
        {
            get { return italicBackground; }
            set
            {
                italicBackground = value;
                OnPropertyChanged();
            }
        }

        private RichTextBox mainRTBProperty;

        public RichTextBox MainRTBProperty
        {
            get { return mainRTBProperty; }
            set
            {
                mainRTBProperty = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel(RichTextBox mainRTB)
        {
            mainRTBProperty = mainRTB;
        }

        public ICommand BoldToggle
        {
            get { return new RelayCommand<object>(p => ToggleBold()); }
        }

        public void ToggleBold()
        {
            Bold = !Bold;
            EditingCommands.ToggleBold.Execute(null, mainRTBProperty);
            if (Bold)
            {
                BoldBackground = Brushes.DarkGray;
            }
            else
            {
                BoldBackground = Brushes.LightGray;
            }
        }

        public ICommand UnderlineToggle
        {
            get { return new RelayCommand<object>(p => ToggleUnderline()); }
        }

        public void ToggleUnderline()
        {
            Underline = !Underline;
            EditingCommands.ToggleUnderline.Execute(null, mainRTBProperty);
            if (Underline)
            {
                UnderlineBackground = Brushes.DarkGray;
            }
            else
            {
                UnderlineBackground = Brushes.LightGray;
            }
        }

        public ICommand ItalicToggle
        {
            get { return new RelayCommand<object>(p => ToggleItalic()); }
        }

        public void ToggleItalic()
        {
            Italic = !Italic;
            EditingCommands.ToggleItalic.Execute(null, mainRTBProperty);
            if (Italic)
            {
                ItalicBackground = Brushes.DarkGray;
            }
            else
            {
                ItalicBackground = Brushes.LightGray;
            }
        }

        #region On property changed implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
