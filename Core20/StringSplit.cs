using System;

namespace Core20
{
    public class StringSplit
    {
        public string[] Split(string str)
        {
            //Compiles
            //Method seen here https://docs.microsoft.com/en-us/dotnet/api/system.string.split?view=netcore-2.0            
            return str.Split(' ', StringSplitOptions.None);
        }
    }
}
