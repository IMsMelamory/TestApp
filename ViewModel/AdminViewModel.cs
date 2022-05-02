using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Helper;
using TestApp.JsonProvider;
using TestApp.Model;
using TestApp.Repository;
using TestApp.View;

namespace TestApp.ViewModel
{
    public class AdminViewModel : BaseTab
    {
        private CardViewModel _selectedCard;
        private CardViewModel _currentCard = new CardViewModel();
        private ObservableCollection<CardViewModel> _card = new ObservableCollection<CardViewModel>();
        private ObservableCollection<CardViewModel> _cards;
        public AdminViewModel()
        {
            AddNewCardCommand = new RelayCommand(AddNewExecute);
            DeleteCardCommand = new RelayCommand(DeleteCardExecute);
            CardRepository = new CardRepository(new JsonProvider<Card>("card.json"));
            UpdateCards();

        }
        public CardRepository CardRepository { get; set; }
        public override string Header => "Админская";
        public RelayCommand AddNewCardCommand { get; set; }
        public RelayCommand DeleteCardCommand { get; set; }
        public ObservableCollection<CardViewModel> Cards
        {
            get => _cards;

            set
            {
                _cards = value;
                OnPropertyChanged();
            }
        }
        public CardViewModel SelectedCard
        {
            get => _selectedCard;
            set
            {
                _selectedCard = value;
                if (SelectedCard != null)
                {
                    CurrentCard = SelectedCard;
                }

                OnPropertyChanged();
            }
        }

        public CardViewModel CurrentCard
        {
            get => _currentCard;
            set
            {
                _currentCard = value;
                OnPropertyChanged();
            }
        }
        public CardMapper CardMap { get; set; } = new CardMapper();
        private void UpdateCards()
        {
            Cards = new ObservableCollection<CardViewModel>(CardMap.ToViewModel(CardRepository.GetAll()).OrderBy(x => x.ID));

        }
        private void AddNewExecute(object arg)
        {
            CardView AddNewCard = new CardView();
            AddNewCard.Show();
        }
        private void DeleteCardExecute(object arg)
        {
            if (SelectedCard == null)
            {
                return;
            }

            CardRepository.RemoveById(SelectedCard.ID);
            UpdateCards();
        }
    }
}
