using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***** Welcome to DevZest WPF docking! *****");
            sb.AppendLine(string.Format("===== CLR Version: {0}, Loaded Assemblies:", Environment.Version));
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
                sb.AppendLine(assembly.FullName);
            output.AppendLog(sb.ToString());

        }
    }
}