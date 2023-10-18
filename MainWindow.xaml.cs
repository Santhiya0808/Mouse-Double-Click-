using System.Windows;
using System.Windows.Input;

namespace Santhiya
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

        private void lblpink_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblpink.Background;
        }

        private void lblgreen_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblgreen.Background;
        }

        private void lblred_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblred.Background;
        }

        private void lblblack_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblblack.Background;
        }

        private void lblmediumorchid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblmediumorchid.Background;
        }

        private void lblnavy_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblnavy.Background;
        }

        private void lblaqua_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblaqua.Background;
        }

        private void lblhotpink_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblhotpink.Background;
        }

        private void lblsalmon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblsalmon.Background;
        }

        private void lblbrown_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblbrown.Background;
        }

        private void lblmaroon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblmaroon.Background;
        }

        private void lblolive_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblolive.Background;
        }

        private void lblmaroon_MouseEnter(object sender, MouseEventArgs e)
        {
            lblover.Background = lblmaroon.Background;
        }

        private void lblmaroon_MouseLeave(object sender, MouseEventArgs e)
        {
            lblmaroon.Background = lblblack.Background;
        }
    }
}
