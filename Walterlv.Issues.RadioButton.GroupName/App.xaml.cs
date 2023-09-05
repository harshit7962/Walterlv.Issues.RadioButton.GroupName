using System.Windows;
using System.Windows.Controls;

namespace Walterlv.Issues
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var button = new Button
            {
                Content = "new window",
            };
            button.Click += Button_Click;
            Window initial = new Window
            {
                Content = button,
                Width = 400,
                Height = 200,
            };
            initial.Show();

            initial.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to close the application?", "Confirmation", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.No)
            {
                e.Cancel = true; // Cancel the application's closing operation
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var m = new MainWindow();
            m.Show();
        }
    }
}
