using fonq_distributiecentrum.Converter;
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
        private ConvertVoorraadVestiging convertforStock = new ConvertVoorraadVestiging();

        // getting local stock, only shows stores with stock.
        public List<LokaalVoorraad> GetProductStock(int productID)
        {

            //return entities.prod_vest_voorraad.Where(productID == LocalStore.product_id).ToList().Select(v => convertforStock.ConvertStoreStock(v)).ToList();

            //Langere versie voor wat hier boven staat.
            var StoreStockList = new List<LokaalVoorraad>();
            foreach (var LocalStore in entities.prod_vest_voorraad)
                if (productID == LocalStore.product_id)
                {
                    StoreStockList.Add(convertforStock.ConvertStoreStock(LocalStore));
                }


            return StoreStockList;
        }

        // begin section updating the local stock
        public LokaalVoorraad GetLocal(int vestigingID, int ProductID)
        {
             
            var entity = entities.prod_vest_voorraad.Single(st => st.vestiging_id == vestigingID 
                                                                && st.product_id == ProductID);
            return convertforStock.ConvertStoreStock(entity);
            }

        //Stock store update en totalstock update
        public void UpdateLocalStock(LokaalVoorraad model)
        {
            var entity = entities.prod_vest_voorraad.Single(st => st.vestiging_id == model.vestigingID 
                                                                && st.product_id == model.ProductID);
            int x = entity.voorraad_vest.HasValue ? entity.voorraad_vest.Value : 0;
            entity.voorraad_vest = model.StoreStock;
            var difference = entity.voorraad_vest - x;
            entity.distributie_product.totalLocal = entity.distributie_product.totalLocal + difference;
            entities.SaveChanges();
            


        }
    }
}