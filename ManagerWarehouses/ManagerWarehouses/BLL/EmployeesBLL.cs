using ManagerWarehouses.DAL;
using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ManagerWarehouses.BLL
{
    public class EmployeesBLL
    {
        public Employees Login(string username, string password)
        {
            try
            {
                using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
                {
                    Console.WriteLine("Employees Login(string username, string password)");
                    var employees = myShoeStoreEntities.Employees.Where(e => e.UserName == username && e.Password == password).SingleOrDefault();
                    if (employees != null)
                        return employees;
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public Employees GetEmployee(long employee_id)
        {
            try
            {
                using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
                {
                    Console.WriteLine("Employees GetEmployee(long employee_id)");
                    return myShoeStoreEntities.Employees.Find(employee_id);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public int ChangePassword(ref Employees employees, string old_password, string new_password, string confim_passoword)
        {
            try
            {
                using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
                {
                    Console.WriteLine("ChangePassword(ref Employees employees, string old_password, string new_password, string confim_passowrd)");
                    if (!old_password.Equals(Global.Employees.Password))
                        return INIT.VERIFY;
                    if (!new_password.Equals(confim_passoword))
                        return INIT.FAIL;
                    employees.Password = new_password;
                    myShoeStoreEntities.Employees.AddOrUpdate(employees);
                    myShoeStoreEntities.SaveChanges();
                    return INIT.SUSSESS;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }


        public void UpdateEmployee(Employees employees)
        {
            try
            {
                using (MyShoeStoreEntities myShoeStoreEntities = new MyShoeStoreEntities())
                {
                    Console.WriteLine("UpdateEmployee(Employees employees)");
                    myShoeStoreEntities.Employees.AddOrUpdate(employees);
                    myShoeStoreEntities.SaveChanges();
                    Console.WriteLine("Chỉnh sửa thông tin thành công");
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
