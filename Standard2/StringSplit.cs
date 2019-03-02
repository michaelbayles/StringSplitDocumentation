using System;

namespace Framework452
{
    public class StringSplit
    {
        public string[] Split(string str)
        {
            //Doesn't compile
            //No method per https://docs.microsoft.com/en-us/dotnet/api/system.string.split?view=netstandard-2.0
            return str.Split(' ', StringSplitOptions.None);
        }
    }
}
