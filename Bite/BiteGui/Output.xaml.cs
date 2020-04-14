using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Baer.BiteGui
{
    /// <summary>
    /// Interaction logic for Output.xaml
    /// </summary>
    public partial class Output
    {
        public Output()
        {
            //InitializeComponent();
        }
        public void AppendLog(string text)
        {
            textBox.AppendText(string.Format("{0}: {1}", DateTime.Now.ToLongTimeString(), text + Environment.NewLine));
            textBox.ScrollToEnd();
        }

        private void OnClearAllClick(object sender, RoutedEventArgs e)
        {
            textBox.Text = null;
        }
    }
}
