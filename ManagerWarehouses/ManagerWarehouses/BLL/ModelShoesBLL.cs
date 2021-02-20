using ManagerWarehouses.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ManagerWarehouses.BLL
{
    public class ModelShoesBLL
    {
        public void Create(ref ModelShoes modelShoes)
        {
            using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
            {
                modelShoes.Status = 1;
                modelShoes = myShoeStoreEntities.ModelShoes.Add(modelShoes);
                myShoeStoreEntities.SaveChanges();
            }
        }

        public void Delete(ModelShoes modelShoes)
        {
            try
            {
                using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
                {
                    Console.WriteLine("Delete(ModelShoes modelShoes)");
                    modelShoes.Status = 0;
                    myShoeStoreEntities.ModelShoes.AddOrUpdate(modelShoes);
                    if (myShoeStoreEntities.SaveChanges() != 1)
                        throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public List<ModelShoes> Read()
        {
            try
            {
                using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
                {
                    Console.WriteLine("Read()");
                    return myShoeStoreEntities.ModelShoes.Where(m => m.Status == 1).ToList().Select(m => new ModelShoes { ModelShoes_ID = m.ModelShoes_ID, NameShoese = m.NameShoese, CompanyID = m.CompanyID, TypeID = m.TypeID, Company = m.Company, TypeShoe = m.TypeShoe }).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;

            }
        }
    }
}
