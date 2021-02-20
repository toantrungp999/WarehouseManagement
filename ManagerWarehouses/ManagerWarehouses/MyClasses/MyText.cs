using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
public static class MyText
{
    public static bool Compare(List<string> danhSach, string chuoi)
    {
        foreach (string a in danhSach)
        {
            if (a == chuoi)
                return true;
        }
        return false;
    }

    public static bool CompareString(string str1, string str2)
    {
        if (str1.Length == 0 || str2.Length == 0)
        {
            return false;
        }
        else if (str1.Length != str2.Length)
        {
            return false;
        }
        int k = 0;
        for (int i = 0; i < str1.Length; i++)
        {

            if (str1[i] == str2[i])
                k++;
        }
        if (k != str1.Length)
            return false;
        return true;
    }

    public static string ConverMD5(this string str)
    {
        StringBuilder str_md5 = new StringBuilder();
        byte[] array = System.Text.Encoding.UTF8.GetBytes(str);

        MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
        array = my_md5.ComputeHash(array);

        foreach (byte b in array)
        {
            str_md5.Append(b.ToString("X2"));
        }

        return str_md5.ToString();
    }

    public static string GetPropertyValue<T>(this T item, string propertyName)
    {
        return item.GetType().GetProperty(propertyName).GetValue(item, null).ToString();
    }

    public static bool ToBoolean(this string str)
    {
        return bool.Parse(str);
    }

    public static int ToInt32(this object obj)
    {
        return int.Parse(obj.ToString());
    }

    public static uint ToUInt32(this object obj)
    {
        return uint.Parse(obj.ToString());
    }

    public static long ToInt64(this object obj)
    {
        return long.Parse(obj.ToString());
    }

    public static ulong ToUInt64(this object obj)
    {
        return ulong.Parse(obj.ToString());
    }
}
