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
using WpfApp.Model.Interfaces;
using WpfApp.ViewModel.Helper;
using WpfApp.ViewModel.Interfaces;

namespace WpfApp.ViewModel
{
	public class NotepadViewModel : OnPropertyChangedImplementation, INavigatable
	{
		public bool Bold { get; set; } = false;

		public bool Underline { get; set; } = false;

		public bool Italic { get; set; } = false;

		private IBaseTheme windowTheme;

		public IBaseTheme WindowTheme
		{
			get { return windowTheme; }
			set { windowTheme = value; }
		}

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

		public NotepadViewModel(RichTextBox mainRTB, ISettings settings)
		{
			globalSettings = settings;
			mainRTBProperty = mainRTB;
			windowTheme = Theme.Dark;
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

		public void OnNavigateTo() { }

		public void OnNavigateAway() { }

		private ISettings globalSettings;
	}
}
