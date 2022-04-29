using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.JsonProvider;
using TestApp.Model;
using TestApp.Repository;

namespace TestApp.ViewModel
{
    public class CatalogViewModel: BaseTab
    {
        public CatalogViewModel()
        {
            CardRepository = new CardRepository(new JsonProvider<Card>("card.json"));

        }
        public CardRepository CardRepository { get; set; }
        public override string Header => "Каталог";
    }
}
