// source: https://www.tutorialspoint.com/csharp/csharp_classes.htm
// filename: tp_class1.cs
// capture date: 29 Mar 2019
// version: original version as captured from tutorialspoint.com
// student: Dan Bahrt
// summary: very simple example of object-oriented program
// modifications: none


using System;

namespace BoxApplication {
    //---------
    // declared a class... a pattern with which objects can be created
    //---------
    class Box {
        // a class can contain data items (fields and properties)
        // as well as methods (functions) that operate on that data

        public double length;   // Length of a box
        public double breadth;  // Breadth of a box
        public double height;   // Height of a box
    }

    //----------
    // startup class... contains Main() static function
    //----------
    class Boxtester {

        //----------
        static void Main(string[] args) {
            // this is a temporary local variable that will hold a
            // double-precision floating point number
            double volume = 0.0;    // Store the volume of a box here

            // instantiate box 1 & initialize it
            Box Box1 = new Box();   // instantiate mean make a copy or instance
            Box1.height = 5.0;
            Box1.length = 6.0;
            Box1.breadth = 7.0;

            // instantiate box 2 & initialize it
            Box Box2 = new Box();   // make another object
            Box2.height = 10.0;
            Box2.length = 12.0;
            Box2.breadth = 13.0;
           
            // calculate volume of box 1
            volume = Box1.height * Box1.length * Box1.breadth;
            Console.WriteLine("Volume of Box1 : {0}",  volume);

            // calculate volume of box 2
            volume = Box2.height * Box2.length * Box2.breadth;
            Console.WriteLine("Volume of Box2 : {0}", volume);

            Console.Write("Press Enter to continue...");
            Console.ReadKey();
        }
    }
}
