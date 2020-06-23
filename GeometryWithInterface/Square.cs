using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryWithInterface {
    class Square : IShapes {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }

        public void Perimeter(int s1, int s2, int s3, int s4) {

            Console.WriteLine($"Perimeter is {s1 + s2 + s3 + s4}");

        }
    }
}
