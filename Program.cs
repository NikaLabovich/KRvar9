using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podgotovka2
{
    class SuperCollection
    {
        public List<string> FirstEx = new List<string>();

        public bool Add<T>(T element)
        {
            FirstEx.Add(Convert.ToString(element));
            return true;
        }
    }

    delegate void Message1();
    delegate int Message2();
    class Point
    {
        public int x = 10;
        public int y = 20;
        public int z = 30;

        public void Clear()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;

            Console.WriteLine("опачки, вызвался метод Clear: " + "x = " + x + " y = " + y + " z = " + z + '\n');
        }

        public int GetSumXYZ()
        {
            Console.WriteLine("опачки, а вот еще и метод GetSumXYZ, как неожиданно");
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SuperCollection super = new SuperCollection();
                super.FirstEx.Add("приветики");
                super.Add<String>("котлетики");
                super.Add<Int32>(12345);
                super.Add<Double>(3.14);
                foreach (string i in super.FirstEx)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();

                int count = 0;
                int[] array = new[] { 4, 6, 7, 0, 32, -12, 3, -100 };
                IEnumerable<int> LArray = array.Where(s => s <= 0);
                foreach (int numb in LArray)
                {
                    Console.WriteLine(numb);
                    count++;
                }
                Console.WriteLine("В итоге получим, что нулевых и отрицательных числиков всего " + count + '\n');
                Point ThirdEx = new Point();
                Message1 Mes1;
                Mes1 = ThirdEx.Clear;
                Mes1();
                Message2 Mes2;
                Mes2 = ThirdEx.GetSumXYZ;
                Mes2();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}

