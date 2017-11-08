using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.Hash
{
    public interface IPVHash
    {
        string Compute(string password);
        //string Compute(string password, int iterations);
        bool Verify(string password, string passwordHashString);        
    }
}
