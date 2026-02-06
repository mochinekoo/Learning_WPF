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


namespace Learning_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int count = 0;
        private Timer timer;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();

            TimerCallback callback = state => {
                Dispatcher.Invoke(() => {
                    MainViewModel view = (MainViewModel)DataContext;
                    view.Progress = count;
                    count++;
                });
            };

            timer = new Timer(callback, null, 0, 1000);
          
        }
    }
}
