using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.Hash
{
    public interface IPVHash
    {
        //PasswordParameters Compute(string password);
        //bool Verify(string password, string salt, string hash);                

         string Compute(string password);
         bool Verify(string password, string passwordHashString);

    }
}
