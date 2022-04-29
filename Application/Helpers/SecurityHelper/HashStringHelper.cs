using System.Security.Cryptography;
using System.Text;

namespace Application.Helpers.SecurityHelper;

public static class HashStringHelper
{
    public static string EncodeSha256(string pass)
    {
        // Create a SHA256   
        using var sha256Hash = SHA256.Create();
        // ComputeHash - returns byte array  
        byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(pass));  
  
        // Convert byte array to a string   
        var builder = new StringBuilder();  
        foreach (var t in bytes)
        {
            builder.Append(t.ToString("x2"));
        }  
        return builder.ToString();
    }
}