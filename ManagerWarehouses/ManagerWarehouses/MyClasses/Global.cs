using ManagerWarehouses;
using ManagerWarehouses.BLL;
using ManagerWarehouses.DAL;
using ManagerWarehouses.GUI;
using System.Collections.Generic;

public static class Global
{
    public static UCManagerImAndEx UCManagerImAndEx;
    public static UCPersonalInformation UCPersonalInformation;
    public static UCManagerWarehousingListImport UCManagerListImport;
    public static UCManagerCompany UCManageCompany;
    public static UCManagerType UCManagerType;
    public static UCManagerModel UCManagerModel;
    public static UCWarehousingImport UCWarehousingImport;
    public static WindowEditPassword WindowEditPassword;
    public static UCManagerExport UCManagerExport;
    public static UCLog UCLog;
    public static MainWindow MainWindow;

    public static EmployeesBLL EmployeesBLL;
    public static ModelShoesBLL ModelShoesBLL;
    public static CompanyBLL CompanyBLL;
    public static TypeShoesBLL TypeShoesBLL;
    public static ImportBLL ImportBLL;
    public static ShoesBLL ShoesBLL;
    public static LogBLL LogBLL;

    public static Employees Employees;
    public static List<Company> ListCompany;
    public static List<TypeShoe> ListTypeShoe;
    public static List<ModelShoes> ListModelShoes;
    public static List<Import> ListImport;
    public static List<Shoes> ListShoes;
    public static List<Log> ListLog;

    public static string[] Color = { "Đỏ", "Tím", "Vàng", "Hồng", "Xanh" };
}