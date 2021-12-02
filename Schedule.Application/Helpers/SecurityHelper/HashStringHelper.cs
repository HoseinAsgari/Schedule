using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Application.Helpers.SecurityHelper
{
    public class HashStringHelper
    {
         public static Task<string> EncodePasswordMd5(string pass) //Encrypt using MD5   
        {
            return Task.Run(() =>
            {
                byte[] originalBytes;
                byte[] encodedBytes;
                MD5 md5;
                //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)   
                md5 = new MD5CryptoServiceProvider();
                originalBytes = Encoding.Default.GetBytes(pass);
                encodedBytes = md5.ComputeHash(originalBytes);
                //Convert encoded bytes back to a 'readable' string   
                return BitConverter.ToString(encodedBytes);
            });            
        }
    }
}