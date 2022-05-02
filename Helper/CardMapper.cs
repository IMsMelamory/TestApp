using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Model;
using TestApp.ViewModel;

namespace TestApp.Helper
{
    public class CardMapper: CardViewModel
    {
        public List<CardViewModel> ToViewModel(List<Card> cards)
        {
            return cards.Select(x => new CardViewModel()
            {
                Name = x.Name,
                Produser = x.Produser,
                Cost = x.Cost,
                Count = x.Count,
                Foto = x.Foto,
                ID = x.ID
            }).ToList();
        }
        public Card ToCard(CardViewModel vmCard)
        {
            return new Card()
            {
                Name = vmCard.Name,
                Produser = vmCard.Produser,
                Cost = vmCard.Cost,
                Count = vmCard.Count,
                Foto = vmCard.Foto,
                ID = vmCard.ID
            };
        }
    }
}
