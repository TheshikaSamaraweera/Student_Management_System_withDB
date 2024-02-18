using Student_Management_System.ViewModels;
using System.Windows;


namespace Student_Management_System.Views
{
    /// <summary>
    /// Interaction logic for ResultsWindow.xaml
    /// </summary>
    public partial class ResultsWindow : Window
    {
        public ResultsWindow(ResultsViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void ListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged_1(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged_2(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
