using ManagerWarehouses.BLL;
using ManagerWarehouses.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManagerWarehouses
{
    public static class Facade
    {
        public static bool IsRefresh;

        public static void CreateModel(string nameShoese, int company_id, int type_id)
        {
            ModelShoes model = new ModelShoes();
            model.NameShoese = nameShoese;
            model.CompanyID = company_id;
            model.TypeID = type_id;
            Global.ModelShoesBLL.Create(ref model);
            Global.ListModelShoes.Add(model);
        }

        public static bool Login(string username, string password)
        {
            Global.EmployeesBLL = new BLL.EmployeesBLL();
            Global.Employees = Global.EmployeesBLL.Login(username, password);
            if (Global.Employees != null)
                return true;
            return false;
        }

        public static int ChangePassword(string old_password, string new_password, string confim_passoword)
        {
            return Global.EmployeesBLL.ChangePassword(ref Global.Employees, old_password, new_password, confim_passoword);
        }

        public static void UpdateEmployee(string fullName, string personalCard, string phoneNumber, byte sex)
        {
            Global.Employees.FullName = fullName;
            Global.Employees.PersonalCard = personalCard;
            Global.Employees.PhoneNumber = phoneNumber;
            Global.Employees.Sex = sex;
            Global.EmployeesBLL.UpdateEmployee(Global.Employees);
        }

        public static void ReadCompany()
        {
            if (Global.ListCompany == null)
            {
                Global.CompanyBLL = new BLL.CompanyBLL();
                Global.ListCompany = Global.CompanyBLL.Read();
            }
        }

        public static void CreateCompany(string companyName)
        {
            Company company = new Company();
            company.CompanyName = companyName;
            company.Status = 1;
            Global.ListCompany.Add(Global.CompanyBLL.Create(company));
        }

        public static void DeleteCompany(int company_id)
        {
            Global.ListCompany.Remove(Global.CompanyBLL.Delete(company_id));
        }

        public static void EditShoes(long shoes_id, int amount, string note, int index)//sua
        {
            for (int i = Global.ListImport.Count - 1; i >= 0; i--)
            {
                Global.ListShoes = Global.ListImport[i].Shoes.ToList();
                for (int j = Global.ListShoes.Count - 1; j >= 0; j--)
                {
                    if (Global.ListShoes[j].Shoes_ID == shoes_id)
                    {
                        int decreases = Global.ListShoes[j].Amount - amount;
                        Global.ListShoes[j].Amount = amount;
                        if (amount == 0)
                            Global.ListShoes[j].Status = 0;
                        if (Global.ShoesBLL == null)
                            Global.ShoesBLL = new ShoesBLL();
                        Global.ShoesBLL.Update(Global.ListShoes[j]);
                        Log log = new Log();
                        log.Action_Date = DateTime.Now.ToString("dd/MM/yyyy");
                        log.Action_By = Global.Employees.Employee_ID;
                        log.Action = INIT.EDIT;
                        log.Shoes_ID = shoes_id;
                        log.Amout = decreases;
                        log.Note = note;
                        if (Global.LogBLL == null)
                            Global.LogBLL = new LogBLL();
                        Global.LogBLL.Create(ref log);
                        if (Global.ListLog != null)
                        {
                            Global.ListLog.Add(log);
                            Global.UCLog._dataGridListLog.Items.Add(log);
                        }
                        if (amount == 0)
                        {
                            Global.ListImport[i].Shoes = Global.ListShoes;
                            Global.UCManagerExport.DeleteDataGrid(Global.ListShoes[j].Shoes_ID);
                            Global.ListShoes.RemoveAt(j);
                            if (Global.ListShoes.Count == 0)
                            {
                                Global.ListImport[i].Done = 1;
                                Global.ImportBLL.Update(Global.ListImport[i]);
                            }
                        }
                        else
                            Global.UCManagerExport._dataGridListShoes.Items[index] = new { Global.ListShoes[j].Shoes_ID, Global.ListShoes[j].ModelShoes_ID, Global.ListShoes[j].Size, Global.ListShoes[j].Color, Global.ListShoes[j].Amount, Global.ListImport[i].ImportDate };
                        return;
                    }
                }
            }
        }

        public static void ExportShoes(long shoes_id, int amount, int index)
        {
            for (int i = Global.ListImport.Count - 1; i >= 0; i--)
            {
                Global.ListShoes = Global.ListImport[i].Shoes.ToList();
                for (int j = Global.ListShoes.Count - 1; j >= 0; j--)
                {
                    if (Global.ListShoes[j].Shoes_ID == shoes_id)
                    {
                        lock (Global.UCManagerExport._dataGridListShoes)
                        {
                            Global.ListShoes[j].Amount = amount;
                            if (amount == 0)
                                Global.ListShoes[j].Status = 0;
                            if (Global.ShoesBLL == null)
                                Global.ShoesBLL = new ShoesBLL();
                            Global.ShoesBLL.Update(Global.ListShoes[j]);
                            if (amount == 0)
                            {
                                Global.UCManagerExport.DeleteDataGrid(Global.ListShoes[j].Shoes_ID);
                                Global.UCManagerListImport.DeleteDataGrid(Global.ListImport[i].Import_ID);
                                Global.ListShoes.RemoveAt(j);
                                Global.ListImport[i].Shoes = Global.ListShoes;
                                if (Global.ListShoes.Count==0)
                                {
                                    Global.ListImport[i].Done = 1;
                                    Global.ImportBLL.Update(Global.ListImport[i]);
                                }
                            }
                            else
                                Global.UCManagerExport._dataGridListShoes.Items[index] = new { Global.ListShoes[j].Shoes_ID, Global.ListShoes[j].ModelShoes_ID, Global.ListShoes[j].Size, Global.ListShoes[j].Color, Global.ListShoes[j].Amount, Global.ListImport[i].ImportDate };
                        }
                        return;
                    }
                }
            }
        }

        public static void ReadTypeShoes()
        {
            if (Global.ListTypeShoe == null)
            {
                Global.TypeShoesBLL = new BLL.TypeShoesBLL();
                Global.ListTypeShoe = Global.TypeShoesBLL.Read();
            }
        }

        public static void CreateTypeShoes(string typeName)
        {
            Global.ListTypeShoe.Add(Global.TypeShoesBLL.Create(typeName));
        }

        public static void DeleteTypeShoes(int typeshoes_id)
        {
            TypeShoe typeShoe = Global.ListTypeShoe.Where(t => t.Type_ID == typeshoes_id).SingleOrDefault();
            Global.TypeShoesBLL.Delete(typeShoe);
            Global.ListTypeShoe.Remove(typeShoe);
        }

        public static void ReadModelShoes()
        {
            if (Global.ListModelShoes == null)
            {
                Global.ModelShoesBLL = new BLL.ModelShoesBLL();
                Global.ListModelShoes = Global.ModelShoesBLL.Read();
            }
        }

        public static void DeleteModelShoes(long modelshoes_id)
        {
            ModelShoes modelShoes = Global.ListModelShoes.Where(model => model.ModelShoes_ID == modelshoes_id).SingleOrDefault();
            Global.ModelShoesBLL.Delete(modelShoes);
            Global.ListModelShoes.Remove(modelShoes);
        }

        public static void ReadImport()
        {
            if (Global.ListImport == null)
            {
                Global.ImportBLL = new ImportBLL();
            }
            Global.ListImport = Global.ImportBLL.Read();
        }

        public static void CreateImport(List<Shoes> tmpListShoes, string note, long employeeID, string date)
        {
            Import import = new Import();
            import.ImportBy = employeeID;
            import.ImportDate = date;
            import.Shoes = tmpListShoes;
            import.Note = note;
            import.Status = 1;
            Global.ImportBLL.Create(ref import);
            Global.UCManagerListImport._dataGridListImport.Items.Add(Global.ListImport.Last());
            Global.UCManagerExport.Load();
        }

        public static void DeleteImport(long import_id, string note)
        {
            Import import = Global.ListImport.Where(i => i.Import_ID == import_id).SingleOrDefault();
            Global.ImportBLL.Delete(import, note, Global.Employees.Employee_ID, DateTime.Now.ToString("dd/MM/yyyy"));
            Global.ListImport.Remove(import);
        }

        public static void ReadLog()
        {
            if (Global.ListLog == null)
            {
                Global.LogBLL = new LogBLL();
                Global.ListLog = Global.LogBLL.Read();
            }
        }

        public static void EditUI(Log log)
        {
            if (Global.ListLog != null)
            {
                Global.ListLog.Add(log);
                Global.UCLog._dataGridListLog.Items.Add(log);
            }
            for (int i = Global.UCManagerExport._dataGridListShoes.Items.Count - 1; i >= 0; i--)
                if (Global.UCManagerExport._dataGridListShoes.Items[i].GetPropertyValue("Shoes_ID").ToInt32() == log.Shoes_ID)
                {
                    Global.UCManagerExport._dataGridListShoes.Items.RemoveAt(i);
                    break;
                }
        }
    }
}
