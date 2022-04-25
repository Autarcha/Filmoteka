using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmoteka.Models
{
    public class Film
    {
        private decimal _rating;
        private int _productionYear;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int ProductionYear { get; set; }
        /*{
            get { return _productionYear;}
            set
            {
                _productionYear = Convert.ToInt32(value);
            } }*/
        public string Genre { get; set; }
        [Range(0,10)]
        public decimal Rating 
        {
            get { return _rating;}
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("value",
                        "Ocena musi być w skali od 0 do 10!");
                }

                _rating = value;
            }

        }
    }
}
