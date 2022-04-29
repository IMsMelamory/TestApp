using System;
using System.Collections.ObjectModel;

namespace TestApp.ViewModel
{
    class MainViewModel: BaseTab
    {
        public MainViewModel()
        {
        var adminViewModel = new AdminViewModel();
        var catalogViewModel = new CatalogViewModel();
        Tab = new ObservableCollection<BaseTab>
          {
            adminViewModel,
            catalogViewModel
          };
        }

    }
}
