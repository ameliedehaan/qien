using fonq_distributiecentrum.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fonq_distributiecentrum.Models
{
    public class LokaalVoorraad
    {
        public string StoreName { get; set; }
        public string Location { get; set; }
        public int vestigingID { get; set; }
        [Required(ErrorMessage = "Je moet een voorraad aangeven.")]
        [validate_stock(ErrorMessage = "Voorraad moet een veelvoud van 2 zijn.")]
        public int StoreStock { get; set; }
        public string AfbeeldingProd { get; set; }
        public int ProductID { get; set; }

    }
}