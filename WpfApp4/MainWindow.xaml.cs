using Microsoft.Win32;
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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFireClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "c# file | *.cs";// filter quyish malumot olishda
            openFileDialog.InitialDirectory = "C:\\temp"; // birinchi kiradigan joyi
            openFileDialog.Title = "File olishdagi title";
            openFileDialog.Multiselect = true; // bir nechta malumot tanlashga imkon beradi
            openFileDialog.ShowDialog();
            bool? result = openFileDialog.ShowDialog();

            if (result == true)
            {
                string[] fileName = openFileDialog.FileNames;
                string[] path = openFileDialog.SafeFileNames;


            }
        }
    }
}