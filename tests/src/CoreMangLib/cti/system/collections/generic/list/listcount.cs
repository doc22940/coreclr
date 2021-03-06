using System;
using System.Collections.Generic;
using System.Collections;
/// <summary>
///Count
/// </summary>
public class ListCount
{
    public static int Main()
    {
        ListCount ListCount = new ListCount();
        TestLibrary.TestFramework.BeginTestCase("ListCount");
        if (ListCount.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Calling count property of List,T is Value type.");
        try
        {
            List<int> myList = new List<int>();
            int count = 10;
            
            int element = 0;
            for (int i = 1; i <= count; i++)
            {
                element = i * count;
                myList.Add(element);
            }

            if (myList.Count != count)
            {
                TestLibrary.TestFramework.LogError("001.1", " calling count property should return " + count);
                retVal = false;
            }


        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool PosTest2()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest2: Calling count property of List,T is reference type.");
        try
        {
            List<string> myList = new List<string>();
            int count = 10;
            string element = string.Empty;
            for (int i = 1; i <= count; i++)
            {
                element = i.ToString();
                myList.Add(element);
            }
            if (myList.Count != count)
            {
                TestLibrary.TestFramework.LogError("002.1", " calling count property should return " + count);
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }

  

}

