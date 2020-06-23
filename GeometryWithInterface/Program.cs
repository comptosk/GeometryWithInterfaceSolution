using System;

namespace GeometryWithInterface {
    class Program {
        static void Main(string[] args) {

            var quad = new Quad {
            };
            quad.Perimeter(1, 2, 3, 4);

            var rect = new Rectangle {
               
            };
            rect.Perimeter(2, 4, 6, 8);

            var square = new Square {
               
            };
            square.Perimeter(3, 5, 7, 9);



            IShapes[] shapes = new IShapes[10];

            shapes[0] = quad;
            shapes[1] = rect;
            shapes[2] = square;

            foreach (var shape in shapes) ;
            
            


            

            
        }
    }
}
