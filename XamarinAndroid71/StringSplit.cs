using System;

namespace XamarinAndroid71
{
    public class StringSplit
    {
        public string[] Split(string str)
        {
            //Compiles
            //No method per https://docs.microsoft.com/en-us/dotnet/api/system.string.split?view=xamarinandroid-7.1
            return str.Split(' ', StringSplitOptions.None);
        }
    }
}
