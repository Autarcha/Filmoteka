using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Filmoteka.Commands;
using Filmoteka.Context;
using Filmoteka.Models;
using Filmoteka.Stores;
using Microsoft.EntityFrameworkCore;

namespace Filmoteka.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private Film _selectedFilm;
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateInsertPanelCommand { get; }
        public ICommand DeleteSelectedFilm { get; }
        public ICollection<Film> Films { get; set; }
        public Film SelectedFilm
        {
            get { return _selectedFilm; }
            set
            {
                _selectedFilm = value;
            }
        }

        public async void Delete()
        {
            var context = new FilmContext();
            if (context.Film.Any(x => x.Id == SelectedFilm.Id))
            {
                MessageBoxResult result = MessageBox.Show(string.Format("Czy na pewno chcesz usunąć z biblioteki film: {0}?", SelectedFilm.Title), "Uwaga", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        context.Remove(SelectedFilm);
                        await context.SaveChangesAsync();
                        MessageBox.Show("Pomyślnie usunięto film z listy. Wciśnij przycisk \"Odśwież\", aby zaktualizować listę", "Filmoteka", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                    case MessageBoxResult.No:
                        break;
                }
            }

        }


        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateInsertPanelCommand = new NavigateInsertPanelCommand(navigationStore);
            NavigateHomeCommand = new NavigateHomeCommand(navigationStore);
            using (var DbContext = new FilmContext())
            {
                Films = DbContext.Film.ToList();
                DeleteSelectedFilm = new RelayCommand(o => Delete());
            }

        }

         
    }
}
