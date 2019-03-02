using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework452
{
    public class StringSplit
    {
        public string[] Split(string str)
        {
            //Doesn't compile
            //No method per https://docs.microsoft.com/en-us/dotnet/api/system.string.split?view=netframework-4.5.2            
            return str.Split(' ', StringSplitOptions.None);
        }
    }
}
