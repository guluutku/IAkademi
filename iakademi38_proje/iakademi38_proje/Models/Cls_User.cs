using System;
using System.Text;
using iakademi38_proje.Models;
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
    }
}

