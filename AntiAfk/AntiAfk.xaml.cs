using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SimWinInput;
using System.Windows;
using System.Runtime.InteropServices;

namespace AntiAfk
{


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();         
        }

        private async void button1_Click(object sender, RoutedEventArgs e)
        {
            string s = "Start";
            string sp = "Stop";

            Random rnd = new Random();
            char[] charArray = new char[] { 'W', 'Q', 'E', ' ' };

            if (button1.Content.ToString() == s)
            {
                button1.Background = Brushes.SeaGreen;
                button1.Content = sp;

                do
                {
                    await System.Threading.Tasks.Task.Delay(3000);
                    SimKeyboard.Press((byte)charArray[rnd.Next(0, charArray.Length)]);
                    tb1.Text = (Int32.Parse(tb1.Text) + 1).ToString();
                }
                while (button1.Content.ToString() == sp);

                tb1.Text = (Int32.Parse("0")).ToString();
            }

            else

            {
                button1.Content = s;
                button1.Background = Brushes.GhostWhite;
            }
        }



        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
            base.OnPreviewKeyDown(e);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string ms = "Mouse Start";
            string mp = "Mouse Stop";

        }
    }
}