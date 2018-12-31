using System;
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

namespace ControlGakta
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int selent = 1;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            string ID2 = IDSend.Text;
            string ID = id.Text;
            string port1=Op1.Text.Substring(0, 5);
            string port2 = Op1.Text.Substring(5, 5);
            string sendtext = text1.Text;
            MainScript send = new MainScript(selent,ID,ID2,port1,port2,sendtext);
            if (selent == 1 || selent == 2)
            {
                send.broad();
            }
            else
            {
                send.sendtextScript();
                text1.Text = "";
            }
            MessageBox.Show("安排上了");
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            selent = 1;
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            selent = 2;
        }

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {
            selent = 3;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("版本V1.0 \nPython版已发布GitHub\n该程序仅供学习计算机网络使用，请勿用于其他目的\n如程序有严重Bug请联系QQ:1029550448");
        }
    }
}
