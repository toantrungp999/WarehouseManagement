using ManagerWarehouses.DAL;
using System;
using System.Data.Entity.Migrations;
namespace ManagerWarehouses.BLL
{
    public class ShoesBLL
    {
        public void Update(Shoes shoes)
        {
            try
            {
                using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
                {
                    Console.WriteLine("Update(Shoes shoes)");
                    myShoeStoreEntities.Shoes.AddOrUpdate(shoes);
                    myShoeStoreEntities.SaveChanges();
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
