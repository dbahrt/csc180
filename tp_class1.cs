// source: https://www.tutorialspoint.com/csharp/csharp_classes.htm
// filename: tp_class1.cs
// capture date: 29 Mar 2019
// version: updated version that corrects a couple of bad programming practices
// student: Dan Bahrt
// summary: very simple example of object-oriented program
// modifications: eliminated public instance variables by making Box()
//     constructor that sets private fields; moved duplicate volume
//     calculations into Box.volume() method; added a few object-oriented
//     tutorial comments.

using System;

namespace BoxApplication {
    //---------
    // declared a box class... a pattern with which box objects can be created
    //---------
    class Box {
        // a class can contain data items (fields and properties)
        // as well as methods (functions) that operate on that data.
        // in object-oriented terminoligy, this is called "encapsulation".

        private double length;   // Length of a box
        private double breadth;  // Breadth of a box
        private double height;   // Height of a box

        //----------
        public Box(double l,double b,double h) {
            this.length=l;
            this.breadth=b;
            this.height=h;
         } // end constructor method Box()

        //----------
        public double volume() {
            return (height*length*breadth);
        } // end method volume()
    }

    //----------
    // startup class... contains Main() static function
    // we normally do not create an object from the Startup class.
    // usually, it contains a few static functions that set up
    // objects that do the work of the program. the Startup class
    // is as close to an old-style procedural program as you are
    // going to get in C#.  if we don't create objects that can
    // talk to each other, we don't have an object-oriented program.
    //----------
    class Boxtester {

        //----------
        static void Main(string[] args) {
            
            // here's what you need to observe in this program...
            // the process or creating an object from a class template
            // is called "instantiation" (pronounced "instanciation").
            // instantiation is a four step process:
            // 1) the new operator allocates a block of memory to hold
            //    a new object.
            // 2) the new operator invokes the specified constructor 
            //    method to initialize the object's block of memory...
            //    instance variables (fields) are set up and initial
            //    values are moved into them.
            // 3) a constructor method is unique in that it does not
            //    return a value (no return value, not even "void").
            //    this is so that the new operator can return a reference
            //    pointer that points indirectly to the newly-created
            //    object. the reference pointer is not really a memory
            //    address, but more of a way to get to that memory address.
            // 4) the assignment operator "shoves" the reference pointer
            //    into a typed variable that points to the object.
            
            // instantiate box 1 & initialize it
            Box Box1 = new Box(6.0,7.0,5.0);

            // instantiate box 2 & initialize it
            Box Box2 = new Box(12.0,13.0,10.0);

            // dump out the calculated volumes of Box 1 & Box 2:
            // encapsulation is a wonderful concept that we will be
            // visiting again and again as we do object-oriented
            // programming. the important idea is that we should 
            // move as much of the code that uses the Box data into
            // Box class methods as possible.
            //
            // for example, rather than accessing the Box data in this
            // function to calculate the volume of the various boxes,
            // whereever it is needed, it is better to create a single
            // volume() method in the Box class that can be invoked
            // wherever it is needed.  (duplicated code is rarely a
            // good idea because it is too easy to proliferate
            // programming errors.)
            
            Console.WriteLine("Volume of Box1 : {0}",  Box1.volume());
            Console.WriteLine("Volume of Box2 : {0}", Box2.volume());

            Console.Write("Press Enter to continue...");
            Console.ReadKey();
        }
    }
}
