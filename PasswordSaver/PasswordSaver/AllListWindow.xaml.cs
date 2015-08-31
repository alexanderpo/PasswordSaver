using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace PasswordSaver
{
    /// <summary>
    /// Interaction logic for AllListWindow.xaml
    /// </summary>
    ///
    public partial class AllListWindow : Window
    {
        public AllListWindow()
        {
            InitializeComponent();
        }

        private void AllList_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }

        private void Save_btn_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, AllListBox.Text);
                MessageBoxButton btn_ok = MessageBoxButton.OK;
                MessageBoxImage msg_img = MessageBoxImage.Asterisk;
                MessageBox.Show("Accounts saved!", "Complete", btn_ok, msg_img);
            }
        }
    }
}