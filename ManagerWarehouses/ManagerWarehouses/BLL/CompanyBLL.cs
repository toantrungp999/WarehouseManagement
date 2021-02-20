using ManagerWarehouses.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ManagerWarehouses.BLL
{
    public class CompanyBLL
    {
        public Company Create(Company company)
        {
            try
            {
                using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
                {
                    Console.WriteLine("Create(string name)");
                    company = myShoeStoreEntities.Company.Add(company);
                    myShoeStoreEntities.SaveChanges();
                    return company;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public void Update(Company company)
        {
            try
            {
                using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
                {
                    Console.WriteLine("Update(Company company)");
                    myShoeStoreEntities.Company.AddOrUpdate(company);
                    myShoeStoreEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public Company Delete(int id)
        {
            try
            {
                using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
                {
                    Company company = Global.ListCompany.Where(c => c.Companny_ID == id).SingleOrDefault();
                    Console.WriteLine("Delete(Company company)");
                    company.Status = 0;
                    myShoeStoreEntities.Company.AddOrUpdate(company);
                    if (myShoeStoreEntities.SaveChanges() != 1)
                        throw new Exception();
                    return company;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public List<Company> Read()
        {
            try
            {
                using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
                {
                    Console.WriteLine("Read()");
                    return myShoeStoreEntities.Company.Where(c => c.Status == 1).ToList();
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
