using fonq_distributiecentrum.Models;
using fonqentity.fonq_database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fonq_distributiecentrum.repositories
{
    public class StoreRepository
    {
        private fonqEntities entities = new fonqEntities();

        // getting local stock, only shows stores with stock.
        public List<LokaalVoorraad> GetProductStock(int productID)
        {
            var StoreStockList = new List<LokaalVoorraad>();
            foreach (var LocalStore in entities.prod_vest_voorraad)
                if (productID == LocalStore.product_id)
                {
                    StoreStockList.Add(new LokaalVoorraad
                    {
                        StoreName = LocalStore.vestiging.naam,
                        StoreStock = LocalStore.voorraad_vest.Value,
                        vestigingID = LocalStore.vestiging_id.Value,
                        Location = LocalStore.vestiging.locatie,
                        ProductID = LocalStore.product_id.Value,
                        AfbeeldingProd = LocalStore.distributie_product.afbeelding
                    }
                );
                }

                    
            return StoreStockList;
        }

        // begin section updating the local stock
        public LokaalVoorraad GetLocal(int vestigingID, int ProductID)
        {
            var entity = entities.prod_vest_voorraad.Single(st => st.vestiging_id == vestigingID 
                                                                && st.product_id == ProductID);
            return new LokaalVoorraad
            {
                StoreName = entity.vestiging.naam,
                Location = entity.vestiging.locatie,
                StoreStock = entity.voorraad_vest.Value,
        };
            }

        //Stock store update en totalstock update
        public void UpdateLocalStock(LokaalVoorraad model)
        {
            var entity = entities.prod_vest_voorraad.Single(st => st.vestiging_id == model.vestigingID 
                                                                && st.product_id == model.ProductID);
            var y = entity.voorraad_vest;
            entity.voorraad_vest = model.StoreStock;
            var x = entity.voorraad_vest;
            var z = x - y;
            entity.distributie_product.totalLocal = entity.distributie_product.totalLocal + z;

            entities.SaveChanges();
            


        }
    }
}