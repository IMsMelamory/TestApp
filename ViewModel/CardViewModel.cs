using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.ViewModel
{
    public class CardViewModel: BaseTab
    {
        private int _id;
        private string _name;
        private string _produser;
        private string _cost;
        private string _foto;
        private int _count;
        public int ID
        {
            get => _id;
            set
            {
                _id = value;
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public string Produser
        {
            get => _produser;
            set
            {
                _produser = value;
                OnPropertyChanged();
            }
        }
        public string Cost
        {
            get => _cost;
            set
            {
                _cost = value;
                OnPropertyChanged();
            }
        }
        public string Foto
        {
            get => _foto;
            set
            {
                _foto = value;
                OnPropertyChanged();
            }
        }
        public int Count
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged();
            }
        }

    }
}
