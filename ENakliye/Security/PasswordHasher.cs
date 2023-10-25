using System;
using System.Text;
using System.Security.Cryptography;
namespace ENakliye.Security
{
    public class PasswordHasher
    {
        /*Bu sınıf string olarak aldığı şifreyi sha256 algoritmasını kullanıp şifreler 
         üretilen sonuç 64 karakterli hash şeklindedir ve veri tabanında bu haliyle tutulacaktır

     Önemli not:bu sınıf kullanıcı her şifreyi girdiğinde çağırılıp veri tabanındaki hash ile denklik karşılaştırılmalı
         */
       public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] data = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(data);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
