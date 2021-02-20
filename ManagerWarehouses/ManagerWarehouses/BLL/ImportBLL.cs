using ManagerWarehouses.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ManagerWarehouses.BLL
{
    public class ImportBLL
    {
        public List<Import> Read()
        {
            try
            {
                using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
                {
                    Console.WriteLine("List<Import> Read()");
                    return myShoeStoreEntities.Import.Where(import => import.Done == 0 && import.Status == 1).ToList().Select(import =>
                    new Import
                    {
                        Import_ID = import.Import_ID,
                        ImportBy = import.ImportBy,
                        ImportDate = import.ImportDate,
                        Note = import.Note,
                        Done = import.Done,
                        Status = import.Status,
                        Employees = import.Employees,
                        Export = import.Export,
                        Shoes = import.Shoes
                    }).ToList(); 
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void Create(ref Import import)
        {
            try
            {
                using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
                {
                    import = myShoeStoreEntities.Import.Add(import);//khong hieu tai sao ko lay het thong tin lien quan
                    myShoeStoreEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void Update(Import import)
        {
            try
            {
                using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
                {
                    myShoeStoreEntities.Import.AddOrUpdate(import);
                    myShoeStoreEntities.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void Delete(Import import, string note, long action_By, string action_Date)
        {
            try
            {
                using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
                {
                    Console.WriteLine("Delete(int id)");
                    var shoes = import.Shoes.ToList();
                    List<Log> listlog = new List<Log>();
                    for (int i = shoes.Count - 1; i >= 0; i--)
                    {
                        Log log = new Log();
                        log.Shoes_ID = shoes[i].Shoes_ID;
                        log.Action_By = action_By;
                        log.Action_Date = action_Date;
                        log.Action = INIT.DELETE;
                        log.Amout = shoes[i].Amount;
                        log.Note = note;
                        log = myShoeStoreEntities.Log.Add(log);
                        listlog.Add(log);
                        shoes[i].Status = 0;
                        myShoeStoreEntities.Shoes.AddOrUpdate(shoes[i]);
                    }
                    import.Status = 0;
                    myShoeStoreEntities.Import.AddOrUpdate(import);
                    myShoeStoreEntities.SaveChanges();
                    for (int i = listlog.Count - 1; i >= 0; i--)
                    {
                        Facade.EditUI(listlog[i]);
                    }
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
