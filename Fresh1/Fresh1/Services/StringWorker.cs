using System;
using System.Collections.Generic;
using System.Text;

namespace Fresh1.Services
{
    public class StringWorker : IStringWorker
    {
        public string SumString(string str1, string str2)
        {
            return $"{str1}-{str2}";
        }
    }
}
