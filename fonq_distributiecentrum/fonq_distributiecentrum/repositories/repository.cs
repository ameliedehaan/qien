using System.Collections.Generic;
using System.Linq;
using System;
using System.Web;
using fonq_distributiecentrum.Models;
using fonqentity;
using fonqentity.fonq_database;

namespace fonqentity.repositories
{
    public class repository
    {

        private fonqEntities entities = new fonqEntities();

        // producten page, shows all products
        public List<producten> GetAllProducts()
        {
            var productenLijst = new List<producten>();
            foreach (var product in entities.distributie_product)
                if (product.Show == true)
                {
                    productenLijst.Add(new producten
                    {
                        naam = product.naam,
                        merk = product.merk,
                        type = product.type,
                        afmetingen = product.aftmetingen,
                        voorraad = product.voorraad,
                        gewicht = Convert.ToDouble(product.gewicht),
                        afbeeldingLink = product.afbeelding,
                        productID = product.product_id,
                        totalLocal = product.totalLocal.Value,
                        Show = product.Show.Value
                    });
                }
           
            return productenLijst;   
        }

        //adds new product
        public void AddNewProduct(producten product_add)
        {
            entities.distributie_product.Add(new distributie_product
            {
                naam = product_add.naam,
                merk = product_add.merk,
                type = product_add.type,
                aftmetingen = product_add.afmetingen,
                gewicht = Convert.ToDecimal(product_add.gewicht),
                voorraad = product_add.voorraad
            });
            entities.SaveChanges();
        }

        // gets product to update
        public producten GetProduct(int ProductID)
        {
            var entity = entities.distributie_product.Single(p => p.product_id == ProductID);
                return new producten
                {
                    naam = entity.naam,
                    merk = entity.merk,
                    type = entity.type,
                    afmetingen = entity.aftmetingen,
                    gewicht = Convert.ToDouble(entity.gewicht),
                    voorraad = entity.voorraad,
                    afbeeldingLink = entity.afbeelding,
                    Show = entity.Show.Value
                };
            
        }

        //updates product
        public void UpdateProduct(producten model)
        {
            var entity = entities.distributie_product.Single(p => p.product_id == model.productID);

            entity.naam = model.naam;
            entity.merk = model.merk;
            entity.type = model.type;
            entity.aftmetingen = model.afmetingen;
            entity.gewicht = Convert.ToDecimal(model.gewicht);
            entity.voorraad = model.voorraad; 
            entity.afbeelding = model.afbeeldingLink;
            entity.Show = model.Show;

            entities.SaveChanges();

        }

        //removes product
        public void RemoveProduct(int ProductID)
        {
            var entity = entities.distributie_product.Single(p => p.product_id == ProductID);
            entity.Show = false;
            //entities.distributie_product.Remove(entity);
            entities.SaveChanges();
        }
        
    }
}
