using System;
using System.Diagnostics;

public class SharedExceptions
{
    public int retVal =0;

    public static int Main()
    {
        Console.WriteLine("Test that StackTrace for OOM is proper if memory is available");
        SharedExceptions test = new SharedExceptions();
        test.RunTest();
        Console.WriteLine(100 == test.retVal ? "Test Passed":"Test Failed");
        return test.retVal;
    }

    public void RunTest()
    {
        CreateAndThrow();        
    }

    public void CreateAndThrow()
    {
    	string currStack;
		
        try
        {
        	throw new Exception();
        }
	catch(Exception e)
	{
		currStack = e.StackTrace;
	}
	
        try
        {            
#if MONO
            var g = Array.CreateInstance (typeof (Guid), Int32.MaxValue);
#else
            Guid[] g = new Guid[Int32.MaxValue];
#endif
        }
        catch(OutOfMemoryException e)
        {
            retVal = 100;
			
            Console.WriteLine("Caught OOM");     

#if MONO
            if (!e.StackTrace.ToString().Contains("SharedExceptions.CreateAndThrow ()"))
                retVal = 50;
#else
            if(e.StackTrace.ToString().Substring(0, e.StackTrace.Length - 8) != currStack.Substring(0, currStack.Length - 8))
            {	
            	Console.WriteLine("Actual Exception Stack Trace:");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine();				
            	Console.WriteLine("Expected Stack Trace:");
		        Console.WriteLine(currStack.ToString());
                retVal = 50;
            }
#endif
        }
            
    }

}

