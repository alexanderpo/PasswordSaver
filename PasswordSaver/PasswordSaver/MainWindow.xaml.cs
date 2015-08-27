using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace PasswordSaver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<AccountData> accountList = new List<AccountData>();
        AllListWindow allListWindow = new AllListWindow();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            accountList.Add(new AccountData
            {
                resourse = ResourceInput.Text,
                login = LoginInput.Text,
                password = PasswordInput.Text
            });

            FileInfo fi = new FileInfo("Resources.txt");
            StreamWriter sw = new StreamWriter(fi.OpenWrite());
            for (int i = 0; i < accountList.Count; i++)
            {
                sw.WriteLine(accountList[i].resourse);
                sw.WriteLine(accountList[i].login);
                sw.WriteLine(accountList[i].password);
            }
            sw.Close();

 
            //в конце добавить востановление значений инпутов
        }

        private void ClearBoxOnFocus(object sender,RoutedEventArgs e)
        {
            if (ResourceInput.IsFocused)
            {
                ResourceInput.Clear();
            }
            else
            {
                if (string.IsNullOrEmpty(ResourceInput.Text))
                {
                    ResourceInput.Text = "Resourse";
                }
            }

            if (LoginInput.IsFocused)
            {
                LoginInput.Clear();
            }
            else
            { 
                if (string.IsNullOrEmpty(LoginInput.Text))
                {
                    LoginInput.Text = "Login name";
                }
            }

            if (PasswordInput.IsFocused)
            {
                PasswordInput.Clear();
            }
            else
            { 
                if (string.IsNullOrEmpty(PasswordInput.Text))
                {
                    PasswordInput.Text = "Password";
                }
            }
        }

        private void AllList_btn_Click(object sender, RoutedEventArgs e)
        {
            allListWindow.Visibility = Visibility.Visible;
        }

        private void Main_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }

    public class AccountData
    {
        public string resourse{ get; set; }
        public string login{ get; set; }
        public string password { get; set; }
    }
}
