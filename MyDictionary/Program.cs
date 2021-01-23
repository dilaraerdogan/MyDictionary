using System;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> customerName = new MyDictionary<int, string>();
            customerName.Add(15,"Dilçağ");
            customerName.Add(24,"Arda");
            customerName.Add(17,"Yıldız");
            customerName.Add(35,"Sedat");
            customerName.Add(21,"Ecrin");
            customerName.Add(56,"Hüseyin");

            customerName.GetAll();
        }
    }
}
