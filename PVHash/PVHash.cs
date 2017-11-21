using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.Hash
{
    public class PVHash : IPVHash
    {
        private int m_SaltSize = 16;
        private int m_HashSize = 32;
        private int m_Iterations = 5000;

        //public PasswordParameters Compute(string password)
        //{
        //    string hashstring;

        //    hashstring = ComputeHashString(password);

        //    return new PasswordParameters
        //    {
        //        Salt = hashstring.Split('$')[0],
        //        Hash = hashstring.Split('$')[1]
        //    };
        //}       

        public string Compute(string password)
        {
            return ComputeHashString(password);
        }

        private string ComputeHashString(string password)
        {
            return ComputeFurther(password, m_Iterations);
        }

        private string ComputeFurther(string password, int iterations)
        {
            using (Rfc2898DeriveBytes objDeriveBytes = new Rfc2898DeriveBytes(password, m_SaltSize, iterations))
            {
                byte[] hash = objDeriveBytes.GetBytes(m_HashSize);
                return CreateHashString(hash, objDeriveBytes.Salt, iterations);
            }
        }

        private string CreateHashString(byte[] hash, byte[] salt, int iterations)
        {
            string saltString = Convert.ToBase64String(salt);
            string hashString = Convert.ToBase64String(hash);
            return string.Join(
                Constants.Splitter.ToString(),
                saltString,
                hashString               
                );            
        }

        //public bool Verify(string password, string salt, string hash)
        //{
        //    return Verify(password, string.Join(Constants.Splitter.ToString(), salt, hash));
        //}

        //public bool Verify(string password, string hashString)
        //{

        //}

        public bool Verify(string password, string passwordHashString)
        {
            string _salt, _hash;
            int _hashSize;
            processParameters(passwordHashString, out _hash, out _salt,out _hashSize);
            //Only test cases start
            //Console.WriteLine("Hash is " + _hash);
            //Console.WriteLine("Salt is " + _salt);
            //test diagnose end

            string newPasswordHash = ComputeHash(password, _salt, _hashSize);

            return _hash == newPasswordHash;
        }

        private void processParameters(string passwordHashString, out string hash, out string salt, out int hashSize)
        {
            salt = passwordHashString.Split('$')[0];
            hash = passwordHashString.Split('$')[1];
            hashSize = Convert.FromBase64String(hash).Length;
        }

        private string ComputeHash(string password, string _salt, int _hashSize)
        {
            byte[] saltBytes = Convert.FromBase64String(_salt);

            using (Rfc2898DeriveBytes objRFC = new Rfc2898DeriveBytes(password, saltBytes, m_Iterations))
            {
                byte[] hash = objRFC.GetBytes(_hashSize);

                return Convert.ToBase64String(hash);
            }
        }
    }
}
