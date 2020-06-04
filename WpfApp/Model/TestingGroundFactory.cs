using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using WpfApp.ViewModel;

namespace WpfApp.Model
{
    public class TestingGroundFactory
    {
        public NotepadViewModel Notepad { get; set; }

        public DataVisualiserViewModel DataVisualiser { get; set; }

        private RichTextBox mainRTB;
        public TestingGroundFactory()
        {
            mainRTB = new RichTextBox();

            Notepad = new NotepadViewModel(mainRTB);

            DataVisualiser = new DataVisualiserViewModel();
        }
    }
}
