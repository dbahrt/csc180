// source: https://www.github.com/dbahrt/csc180/hello.pat
// author: Dan Bahrt
// filename: hello.pat
// last update: 29 Mar 2019
// summary: ...
// modifications: ...


// almost all of the comments in this file are tutorial in nature, and 
// when this pattern is placed or copied into some source code file,
// I suggest removing or minimizing these comments.
// 
// this coding pattern exercise is aimed at developing a relatively
// small list of high-value "building blocks" that, when used in
// software development and whiteboard coding exercises, exhibit 
// Pareto principle (AKA the 80/20 rule) efficiency. my goal is to 
// isolate maybe 10-12 of these coding patterns that can be learned,
// practiced, and combined to form a large portion (80%?) of all 
// the command line interface (CLI) code you will ever write.
//
// even though the "hello world" sample program is sometimes
// ridiculed as a valid starting point in learning to program:
// 1) it will be found virtually in its entirety in every c# program
// that you will ever write.
// 2) it introduces a few of the basic coding patterns
// (classdef, functiondef, functioncall, etc.) that will be
// used over and over again in just about all programs.
// 3) as I subsequently explain in the driver() function,
// the "hello world" program demonstrates basic Console text-based
// input/output, which I claim constitutes a significant part
// (maybe 5-15%) of all CLI programs.
// 4) the basic pattern of most computer programs is historically
// called input-processing-output-and-storage... input and output
// figure prominently in this model, especially when you consider
// that storage is almost all input-output. 
// bottom line... the "hello world" program is probably the best place
// to start learning how to program.

using System;

namespace mypgms {

//==========
// Startup class is an example of a "class" code block.
//
// in structure and function, it is just like any other class.
// in practice, however, we rarely, if ever, instantiate or
// create objects from the Startup class.  mostly it serves as
// a container for a small number of static functions,
// i.e. functions whose address is determined by the compiler.
//
// these static functions include Main(), which serves as
// the entry point for the program, as well as a theoretically 
// small number of static helper functions ( one of which
// I usually call driver() because it outlines the overall
// function of the program ),
// whose essential job was to instantiate a set of
// communicating objects that work together to accomplish
// the work of the program.
//
// the Startup class is as close to an old-style procedural
// program (NOT object-oriented) as we can get in
// the c# programming language.
//==========
public class Startup {
    private const int SUCCESS=0;
    private const int FAIL=1;

    //----------
    // Main() function is an example of a "function" code block.
    //
    // Main() serves as the program entry point.
    // it is just like any other function except for the fact that
    // the compiler requires that there is just one Main() function
    // per executable (.exe) assembly.
    // 
    // normally, the operating system loads and starts executing
    // the assembly at one of the "overloaded" Main() functions:
    //     static int Main( )
    //     static void Main( )
    //     static int Main( string [] args )
    //     static void Main( string [] args )
    //
    // one of the big mistakes beginning programmers make is
    // trying to pack too much functionality into any given function.
    // although we might be able to cram an entire program into
    // the Main() function, we should never do this as it is bad form.
    // ideally, any given function should perform just one logical task. 
    //
    //----------
    // Main() is responsible for:
    // 1) handling the inputs to the program (command line arguments),
    // 2) calling a driver() function overseeing the program functionality, and
    // 3) returning the output result of the program.
    //----------
    public static int Main( string [] args ) {
        // check out input parameters being passed in from the command line.
        // this is an example of a "function call" code block:
        Useful.dumpStringArray( args, "command line arguments:" );

        int result=driver();

        // return the terminal status of the program back to the user.
        // normally for command line interface programs,
        // a return code of 0 means "SUCCESS"
        // anything else means "FAIL"
        Console.WriteLine("\ndisplay result by typing ");
        Console.WriteLine("    \"echo %ERRORLEVEL%\" in Windows, or ");
        Console.WriteLine("    \"echo $?\" in Linux \n");
        return result;
    } // end Main() function

    //----------
    // driver() function is an example of an additional "function" code block.
    //
    // this driver() function effects the program functionality.
    // returns SUCCESS if the work gets done; FAIL if it does not.
    //----------
    private static int driver( ) {
        // two of the most used c# function code statements provide for
        // output to the console screen and input from the console keyboard.
        // in a command line interface (CLI) program, I estimate that maybe
        // 5-15% of the code will be some kind of input/output statements.
        Console.WriteLine("Hello, World.\n");

        //=========================================//
        // additional function data & code blocks. //
        // these blocks need to be carefully       //
        // placed inside a function or method.     //
        //=========================================//

        // pause so that Visual Studio does not close
        // the developer command prompt window before
        // we get a chance to read this program's output...
        Console.Write("Press Enter to continue...");
        // this function call reads a string of character input
        // from the keyboard.  in this case, we don't care about
        // anything but the terminating end-of-line character.
        Console.ReadLine();

        return SUCCESS;
    } // end function driver()

    //=======================================================//
    // additional class data, function & method code blocks. //
    // these blocks are placed inside the class, but         //
    // outside of any other functions or methods.            //
    //=======================================================//

} // end class Startup
    
//================================//
// additional class code blocks.  //
// these blocks are placed inside //
// the namespace, but outside of  //
// any other other classes.       //
//================================//

//==========
// Useful class is an example of a "class" code block.
//
// normally, unless they are inseparably connected with
// the Startup class of the assembly, additional classes
// are placed in separate .cs source code files. 
// the c# compiler then allows you to merge these classes
// into assemblies at compile time. this is great for code
// reuse... it makes classes into a kind of building blocks.
// 
// for the purposes of this class, however, I would like all
// of your sample programs to be contained completely in
// one source code file.  thus we are going to put multiple
// classes in one file, as follows.
//==========
public class Useful {

    //----------
    public static void dumpStringArray(
        string [] args,
        string array_label) {

        if(args.Length!=0) {
            Console.WriteLine(array_label);
            for(int ii=0;ii<args.Length;ii++) {
                Console.WriteLine("["+ii+"]="+args[ii]);
            }
            Console.WriteLine();
        }
        return;
    } // end dumpStringArray()

} // end class Useful
    
} // end namespace mypgms

