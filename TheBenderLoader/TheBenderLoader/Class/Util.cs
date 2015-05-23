using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TheBenderLoader.Class
{
    public static class Util
    {
        public static string GetMd5HashOfAFile(string file)
        {
            var md5 = new MD5CryptoServiceProvider();
            var stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
            md5.ComputeHash(stream);
            stream.Close();
            var hash = md5.Hash;
            var sb = new StringBuilder();
            foreach (var b in hash)
            {
                sb.Append(string.Format("{0:X2}", b));
            }
            return sb.ToString();
        }

        


    }
}
