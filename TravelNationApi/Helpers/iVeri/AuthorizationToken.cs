using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TravelNationApi.Helpers.iVeri
{
    public class AuthorizationToken
    {
        public string GetAuthorizationToken()
        {
            MD5 md5Hash = MD5.Create();
            SHA256 sha256 = SHA256.Create();
            string formattedDateTime = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff");
            byte[] urlInBytes = Encoding.UTF8.GetBytes("url");
            byte[] timeStampInBytes = Encoding.UTF8.GetBytes(formattedDateTime);
            byte[] hashedPasswordInBytes = md5Hash.ComputeHash(Encoding.UTF8.GetBytes("password"));
            byte[] token = new byte[urlInBytes.Length + timeStampInBytes.Length + hashedPasswordInBytes.Length];
            Buffer.BlockCopy(urlInBytes, 0, token, 0, urlInBytes.Length);
            Buffer.BlockCopy(timeStampInBytes, 0, token, urlInBytes.Length, timeStampInBytes.Length);
            Buffer.BlockCopy(hashedPasswordInBytes, 0, token, urlInBytes.Length + timeStampInBytes.Length, hashedPasswordInBytes.Length);
            byte[] hashedTokenInBytes = sha256.ComputeHash(token);

            string base64Token = Convert.ToBase64String(hashedTokenInBytes);

            return base64Token;
        }
    }
}
