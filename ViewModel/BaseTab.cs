using System.Collections.ObjectModel;

namespace TestApp.ViewModel
{
    public class BaseTab : BaseViewModel
    {
        public ObservableCollection<BaseTab> Tab { get; set; }
    }
}
