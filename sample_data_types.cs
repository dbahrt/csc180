// author: Dan Bahrt
// sample_data_types.cs (coding_patterns/hello_readStringsFromKeyboard.cs)
// last updated: 8 Apr 2019


using System;
using System.Collections.Generic;

namespace mypgms {

//==========
public class Startup {
    private const int SUCCESS=0;
    private const int FAIL=1;

    //----------
    public static int Main( string [] args ) {
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
    private static int driver( ) {
        Console.WriteLine("Hello, World.\n");

        List<string> inpstrings;
        readStringsFromKeyboard(out inpstrings);
        Useful.dumpStringList(inpstrings, "keyboard input:");

        Console.Write("Press Enter to continue...");
        Console.ReadLine();

        return SUCCESS;
    } // end function driver()

    //----------
    private static bool readStringsFromKeyboard(
        out List<string> result
    ) {

        result=new List<string>();

        for(;;) {
            string inpstr="";
                inpstr=Console.ReadLine();
                if(inpstr==null) {
                    Console.WriteLine("inpstr is null");
                    break;
                }
                if(inpstr.Trim()=="") {
                    Console.WriteLine("EOF detected");
                    break;
                }

                result.Add(inpstr);

                tryTypeConversions(inpstr);
        }

Console.WriteLine(inpstr);
            Byte outByte;
            if(Byte.TryParse(inpstr,out outByte)) {
                Console.WriteLine("    Byte\t"+outByte);
            }

            SByte outSByte;
            if(SByte.TryParse(inpstr,out outSByte)) {
                Console.WriteLine("    SByte\t"+outSByte);
            }

            Int16 outInt16;
            if(Int16.TryParse(inpstr,out outInt16)) {
                Console.WriteLine("    Int16\t"+outInt16);
            }

            UInt16 outUInt16;
            if(UInt16.TryParse(inpstr,out outUInt16)) {
                Console.WriteLine("    UInt16\t"+outUInt16);
            }

            Int32 outInt32;
            if(Int32.TryParse(inpstr,out outInt32)) {
                Console.WriteLine("    Int32\t"+outInt32);
            }

            UInt32 outUInt32;
            if(UInt32.TryParse(inpstr,out outUInt32)) {
                Console.WriteLine("    UInt32\t"+outUInt32);
            }

            Int64 outInt64;
            if(Int64.TryParse(inpstr,out outInt64)) {
                Console.WriteLine("    Int64\t"+outInt64);
            }

            UInt64 outUInt64;
            if(UInt64.TryParse(inpstr,out outUInt64)) {
                Console.WriteLine("    UInt64\t"+outUInt64);
            }

            Single outSingle;
            if(Single.TryParse(inpstr,out outSingle)) {
                Console.WriteLine("    Single\t"+outSingle);
            }

            Double outDouble;
            if(Double.TryParse(inpstr,out outDouble)) {
                Console.WriteLine("    Double\t"+outDouble);
            }

            Decimal outDecimal;
            if(Decimal.TryParse(inpstr,out outDecimal)) {
                Console.WriteLine("    Decimal\t"+outDecimal);
            }
           
            Boolean outBoolean;
            if(Boolean.TryParse(inpstr,out outBoolean)) {
                Console.WriteLine("    Boolean\t"+outBoolean);
            }
           
            DateTime outDateTime;
            if(DateTime.TryParse(inpstr,out outDateTime)) {
                Console.WriteLine("    DateTime\t"+outDateTime);
            }
           
        return true;
    } // end function readStringsFromKeyboard()

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

    //----------
    public static void dumpStringList(
        List<string> strings,
        string list_label
    ) {

        if(strings.Count!=0) {
            Console.WriteLine(list_label);
            for(int ii=0;ii<strings.Count;ii++) {
                Console.WriteLine("["+ii+"]="+strings[ii]);
            }
            Console.WriteLine();
        }
        return;
    } // end dumpStringList()

} // end class Useful

} // end namespace namespacename

/*

*/
