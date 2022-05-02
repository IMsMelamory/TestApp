using System;
using System.Windows;
using TestApp.Helper;
using TestApp.JsonProvider;
using TestApp.Model;
using TestApp.Repository;

namespace TestApp.ViewModel
{
    public class AddNewCardViewModel:BaseTab
    {
        private CardViewModel _selectedCard;
        private CardViewModel _currentCard = new CardViewModel();
        public AddNewCardViewModel()
        {
            AddNewCardCommand = new RelayCommand(AddNewExecute);
            CardRepository = new CardRepository(new JsonProvider<Card>("card.json"));
        }
        public CardRepository CardRepository { get; set; }
        public CardMapper CardMapper { get; set; } = new CardMapper();
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
        public RelayCommand AddNewCardCommand { get; set; }
        private void AddNewExecute(object arg)
        {
            CurrentCard.ID = CardRepository.FindMaxIDCard()+ 1;
            try
            {
                CardRepository.Add(CardMapper.ToCard(CurrentCard));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

           // UpdateCars();
           // ClearFields();
        }
    }
}
