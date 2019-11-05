using fonq_distributiecentrum.Models;
using fonqentity.fonq_database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fonq_distributiecentrum.Converter
{
    public class ConvertVoorraadVestiging
    {
        public LokaalVoorraad ConvertStoreStock(prod_vest_voorraad entity)
        {
            return new LokaalVoorraad
            {
                vestigingID = entity.vestiging_id.Value,
                StoreName = entity.vestiging.naam,
                Location = entity.vestiging.locatie,
                ProductID = entity.product_id.Value,
                StoreStock = entity.voorraad_vest.HasValue ? entity.voorraad_vest.Value : 0,
                //AfbeeldingProd = entity.distributie_product.afbeelding
            };
        }
    }
}