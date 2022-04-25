using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmoteka.Stores;
using Filmoteka.ViewModels;

namespace Filmoteka.Commands
{
    public class NavigateInsertPanelCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateInsertPanelCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new InsertPanelViewModel(_navigationStore);
        }
    }
}
