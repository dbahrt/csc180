// source: https://www.github.com/dbahrt/csc180/hello.cs
// author: Dan Bahrt
// filename: hello.cs
// last update: 29 Mar 2019
// summary: ...
// modifications: ...

using System;

namespace mypgms {

//==========
public class Startup {
    private const int SUCCESS=0;
    private const int FAIL=1;

    //----------
    // main() serves as the program entry point.
    // gotta have one Main() function per program.
    // it is responsible for:
    // 1) handling the inputs to the program (command line arguments),
    // 2) overseeing the program functionality, and
    // 3) returning the output result of the program.
    //----------
    public static int Main( string [] args ) {
        Useful.dumpStringArray( args, "command line arguments:" );

        int result=driver();

        Console.WriteLine("\ndisplay result by typing ");
        Console.WriteLine("    \"echo %ERRORLEVEL%\" in Windows, or ");
        Console.WriteLine("    \"echo $?\" in Linux \n");
        return result;
    } // end Main() function

    //----------
    // this driver() function effects the program functionality.
    // returns SUCCESS if the work gets done; FAIL if it does not.
    //----------
    private static int driver( ) {
        Console.WriteLine("Hello, World.\n");

        Console.Write("Press Enter to continue...");
        Console.ReadLine();

        return SUCCESS;
    } // end function driver()

} // end class Startup
    

//==========
public class Useful {

    //----------
    public static void dumpStringArray(
        string [] args,
        string array_label
    ) {

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

