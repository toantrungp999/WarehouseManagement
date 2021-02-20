using ManagerWarehouses.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ManagerWarehouses.BLL
{
    public class TypeShoesBLL
    {
        public TypeShoe Create(string typeName)
        {
            try
            {
                using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
                {
                    Console.WriteLine("Create(string typeName)");
                    TypeShoe typeShoe = new TypeShoe();
                    typeShoe.TypeName = typeName;
                    typeShoe.Status = 1;
                    typeShoe = myShoeStoreEntities.TypeShoe.Add(typeShoe);
                    myShoeStoreEntities.SaveChanges();
                    return typeShoe;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void Delete(TypeShoe typeShoe)
        {
            try
            {
                using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
                {
                    Console.WriteLine("Delete(int id)");
                    typeShoe.Status = 0;
                    myShoeStoreEntities.TypeShoe.AddOrUpdate(typeShoe);
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

        public List<TypeShoe> Read()
        {
            try
            {
                using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
                {
                    Console.WriteLine("Read()");
                    return myShoeStoreEntities.TypeShoe.Where(c => c.Status == 1).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public Company Read(int id)
        {
            return null;
        }
    }
}