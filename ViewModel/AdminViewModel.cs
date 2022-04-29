using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.JsonProvider;
using TestApp.Model;
using TestApp.Repository;
using TestApp.View;

namespace TestApp.ViewModel
{
    public class AdminViewModel : BaseTab
    {
        private ObservableCollection<CardViewModel> _card = new ObservableCollection<CardViewModel>();
        public AdminViewModel()
        {
            AddNewCardCommand = new RelayCommand(AddNewExecute);
            CardRepository = new CardRepository(new JsonProvider<Card>("card.json"));

        }
        public CardRepository CardRepository { get; set; }
        public override string Header => "Админская";
        public RelayCommand AddNewCardCommand { get; set; }
        private void UpdateCard()
        {

        }
        private void AddNewExecute(object arg)
        {
            CardView AddNewCard = new CardView();
            AddNewCard.Show();
        }
    }
}
