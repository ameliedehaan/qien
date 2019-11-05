using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fonq_distributiecentrum.Models
{
    public class LokaalVoorraad
    {
        public string StoreName { get; set; }
        public string Location { get; set; }
        public int vestigingID { get; set; }
        public int StoreStock { get; set; }
        public string AfbeeldingProd { get; set; }
        public int ProductID { get; set; }

    }
}