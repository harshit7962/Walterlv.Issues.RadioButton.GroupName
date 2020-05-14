using System.ComponentModel;
using System.Windows;

namespace Walterlv.Issues
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class Foo : INotifyPropertyChanged
    {
        public static Foo Instance { get; } = new Foo();

        public bool Bar
        {
            get => _bar;
            set
            {
                if (!Equals(_bar, value))
                {
                    _bar = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bar)));
                }
            }
        }

        private bool _bar;
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
