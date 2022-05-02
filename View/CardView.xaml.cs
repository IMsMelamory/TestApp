
using System.Windows;
using TestApp.ViewModel;

namespace TestApp.View
{
    /// <summary>
    /// Interaction logic for CardView.xaml
    /// </summary>
    public partial class CardView : Window
    {
        public CardView()
        {
            InitializeComponent();
            DataContext = new AddNewCardViewModel();
        }
    }
}
