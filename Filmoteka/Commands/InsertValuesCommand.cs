using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmoteka.Context;
using Filmoteka.Models;

namespace Filmoteka.Commands
{
    public class InsertValuesCommand : CommandBase
    {
        private FilmContext context = new FilmContext();
        private Film film;
        public InsertValuesCommand(Film film)
        {
            this.film = film;
        }

        public override void Execute(object parameter)
        {
            context.Update(film);
            context.SaveChanges();
        }
    }
}
