﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBonanza
{
    class Movies
    {
        //Movie Title Info
        public string Title { get; set; }

        //Movie genre info
        public string Genre { get; set; }

        //Movie cost Info
        public string Cost { get; set; }

        //Movie Grand total info
        public string GrandTotal { get; set; }

        //Movie picture
        public System.Drawing.Bitmap Picture { get; set; }


        public String MovieIndex (int _index)
        {
            return "CedarRapids";
        }


    }
}
