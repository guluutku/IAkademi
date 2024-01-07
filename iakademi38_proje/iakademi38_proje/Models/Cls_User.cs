using System;
using System.Runtime.InteropServices;
using System.Text;
using iakademi38_proje.Models;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.EntityFrameworkCore;
using XSystem.Security.Cryptography;

namespace iakademi38_proje.Models
{
    public class Cls_User
    {
        iakademi38Context context = new iakademi38Context();

        // RepositoryUser -> class ismi
        // IRepositoryUser -> interface ismi
        public Cls_User()
        {
        }

        public async Task<User?> LoginController(User user)
        {
            string md5Sifre = MD5Sifrele(user.Password);

            User? usr = await context.Users.FirstOrDefaultAsync(u => u.Email == user.Email && u.Password == md5Sifre && u.IsAdmin == true && u.IsActive == true);
            return usr;
        }

        public static string MD5Sifrele(string value)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] btr = Encoding.UTF8.GetBytes(value);
            btr = md5.ComputeHash(btr);

            StringBuilder sb = new StringBuilder();
            foreach (byte item in btr)
            {
                sb.Append(item.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

        public static User? SelectMemberInfo(string? Email)
        {
            using (iakademi38Context context = new iakademi38Context())
            {
                User user = context.Users.FirstOrDefault(u => u.Email == Email)!;
                return user;
            }
        }


        public static string MemberControl(User user)
        {
            using (iakademi38Context context = new iakademi38Context())
            {
                string answer = "";

                try
                {
                    string md5Sifre = MD5Sifrele(user.Password);
                    User? usr = context.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == md5Sifre);

                    if (usr == null)
                    {
                        //kullanıcı yanlıs sifre veya emal girdi
                        answer = "error";
                    }
                    else
                    {
                        //kullanıcı veritabanında kayıtlı.
                        if (usr.IsAdmin == true)
                        {
                            //admin yetkisi olan personel giriş yapıyor
                            answer = "admin";
                        }
                        else
                        {
                            answer = usr.Email;
                        }
                    }
                }
                catch (Exception)
                {
                    return "HATA";
                }

                return answer;
            }
        }

        public static bool loginEmailControl(User user)
        {
            using(iakademi38Context context = new iakademi38Context())
            {
                User usr = context.Users.FirstOrDefault(u => u.Email == user.Email);
                if(usr == null) return false;
                return true;
            }
        }

        public static bool AddUser(User user)
        {
            using (iakademi38Context context = new iakademi38Context())
            {
                try
                {
                    user.IsActive = true;
                    user.IsAdmin = false;
                    user.Password = MD5Sifrele(user.Password);
                    context.Users.Add(user);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}

