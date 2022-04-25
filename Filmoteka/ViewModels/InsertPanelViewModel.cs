using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Filmoteka.Commands;
using Filmoteka.Models;
using Filmoteka.Stores;

namespace Filmoteka.ViewModels
{
    public class InsertPanelViewModel : ViewModelBase
    {
        public ICommand NavigateHomeCommand { get; }
        public ICommand InsertValuesCommand { get; }
        public Film Film { get; set; }

        public InsertPanelViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new NavigateHomeCommand(navigationStore);
            Film = new Film();
            InsertValuesCommand = new InsertValuesCommand(Film);
        }





    }
}
