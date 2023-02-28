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

        public ReceptViewModel(string[,] most_popular)
        {
            Recepts = new ObservableCollection<Recept>();
            for (int i = 0; i < most_popular.GetUpperBound(0) + 1; i++)
            {
                Recepts.Add(new Model.Recept(most_popular[i, 0], most_popular[i, 1], most_popular[i, 2]));
            }
            
        }
    }
}