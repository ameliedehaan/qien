using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using fonqentity;
using fonq_distributiecentrum.Models;
using System.ComponentModel.DataAnnotations;
using fonq_distributiecentrum.Validations;

namespace fonq_distributiecentrum.Models
{
    public class producten
    {
        [Required(ErrorMessage = "Je moet een naam invullen.")]
        [StringLength(50)]
        public string naam { get; set; }


        [Required(ErrorMessage = "Je moet een type invullen.")]
        [StringLength(50)]
        public string type { get; set; }
        public string merk { get; set; }
        public string afmetingen { get; set; }
        public double gewicht { get; set; }

        [Required(ErrorMessage = "Je moet een voorraad aangeven.")]
        [validate_stock(ErrorMessage = "Voorraad moet een veelvoud van 2 zijn.")]
        public int voorraad { get; set; }

        public int productID { get; set; }

        public string afbeeldingLink { get; set; }
        [Required(ErrorMessage = "Je moet een voorraad aangeven.")]
        [validate_stock(ErrorMessage = "Voorraad moet een veelvoud van 2 zijn.")]
        public int totalLocal { get; set; }
        public bool Show { get; set; }
    }
}