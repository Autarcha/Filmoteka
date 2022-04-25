using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Filmoteka.Context;
using Filmoteka.Models;

namespace Filmoteka.Views
{
    /// <summary>
    /// Interaction logic for InsertPanelView.xaml
    /// </summary>
    public partial class InsertPanelView : UserControl
    {
        public InsertPanelView()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            TitleBox.Clear();
            DirectorBox.Clear();
            ProductionYearBox.Clear();
            GenreBox.Clear();
            RatingBox.Clear();
            SuccessInsertMessageBlock.Text = "Pomyślnie wprowadzono film do biblioteki";
        }
    }
}
