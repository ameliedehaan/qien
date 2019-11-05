using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fonq_distributiecentrum.Models
{
    public class single_product
    {
        public string AfbeeldingProd { get; set; }

    }
    public class LokaalVoorraadAfb
    {
        public string StoreName { get; set; }
        public string Location { get; set; }
        public int vestigingID { get; set; }
        public int StoreStock { get; set; }

    }
}