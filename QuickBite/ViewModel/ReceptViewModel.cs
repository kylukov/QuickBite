using QuickBite.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBite.ViewModel
{
    internal class ReceptViewModel
    {
        public ObservableCollection<Recept> Recepts { get; set; }

        public ReceptViewModel()
        {
            Recepts = new ObservableCollection<Recept>();
        }
    }
}