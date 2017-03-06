using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBonanza
{
    /// <summary>
    /// App Name - Movie Bonanza
    /// Author - Balpreet Punia
    /// Student Id - 200335082
    /// Creation Date - 2017-03-05
    /// Description - This app lets user select a movie to stream and also lets them order a DVD for the same.
    /// </summary>

        //This class stores the information about the movie.
    class Movies
    {
        //Movie Title 
        public string Title { get; set; }

        //Movie category
        public string Category { get; set; }

        //Movie cost
        public Double Cost { get; set; }

        //Movie grandtotal 
        public string GrandTotal { get; set; }

        //Movie picture
        public System.Drawing.Image Image { get; set; }


    }
}
