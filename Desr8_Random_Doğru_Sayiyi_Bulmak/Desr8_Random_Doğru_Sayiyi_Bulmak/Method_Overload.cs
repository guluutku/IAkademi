using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desr8_Random_Doğru_Sayiyi_Bulmak
{
    public class Method_Overload
    {
        public void method1() { }
        public void method1(int yas) { }
        public void method1(string ad) { }
        public void method1(string ad, int yas) { }
        public void method1(int yas, string ad) { }
    }
}
