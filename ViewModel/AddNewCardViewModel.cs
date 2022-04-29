using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.ViewModel
{
    public class AddNewCardViewModel:BaseTab
    {
        private CardViewModel _selectedCard;
        private CardViewModel _currentCard = new CardViewModel();
        public AddNewCardViewModel()
        {

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
    }
}
