using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFMyServiceLibrary
{
    public class MyService: IMyService
    {
        public string Method1(string x)
        {
            return $"1 You entered: {x}===1";
        }
        public string Method2(string x)
        {
            //$-интерполяция строк вместо string.format
            return $"2 You entered: {x}===2";
        }
    }
}
