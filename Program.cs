using System;
using System.Text;

namespace GiaiPhuongTrinhBac1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;

            float a;
            float b;
            float x;
            Console.WriteLine("Giải phương trình bậc nhất ax+b=0");
            Console.Write("Nhập vào giá trị của a: ");
            a= float.Parse(Console.ReadLine());
            Console.Write("Nhập vào giá trị của b: ");
            b= float.Parse(Console.ReadLine());

            if(a!=0)
            {
                
                x=-b/a ;
                Console.Write("Phương trinh có nghiệm x là: " + x);
            }
            else if (b==0)
            {
                Console.Write("Phương trình vô số nghiệm");
            }
            else
            {
                Console.Write("Phương trình vô nghiệm");
            }
            Console.ReadLine();
        }
    }
}
