using System;
using System.Reflection;

/// <summary>
///  HasDefault [v-ly]
/// </summary>
public class ParameterAttributesHasDefault
{
    public static int Main()
    {
        ParameterAttributesHasDefault test = new ParameterAttributesHasDefault();

        TestLibrary.TestFramework.BeginTestCase("ParameterAttributesHasDefault");

        if (test.RunTests())
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

        //TestLibrary.TestFramework.LogInformation("[Negative]");
        //retVal = NegTest1() && retVal;

        return retVal;
    }

    #region Postive Test Case
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: ");

        try
        {
            int expected = 0x1000;
            int actual = (int)ParameterAttributes.HasDefault;
            if (expected != actual)
            {
                TestLibrary.TestFramework.LogError("001.1", "HasDefault's value is not 0x0400");
                TestLibrary.TestFramework.LogInformation("WARNING [LOCAL VARIABLES] expected = " + expected + ", actual = " + actual);
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception occurs: " + e);
            TestLibrary.TestFramework.LogInformation(e.Message);
            retVal = false;
        }

        return retVal;
    }
    #endregion

    #region Nagetive Test Cases
    //public bool NegTest1()
    //{
    //    bool retVal = true;

    //    TestLibrary.TestFramework.BeginScenario("NegTest1: ");

    //    try
    //    {
    //    }
    //    catch (Exception e)
    //    {
    //        TestLibrary.TestFramework.LogError("101.0", "Unexpected exception: " + e);
    //        TestLibrary.TestFramework.LogInformation(e.StackTrace);
    //        retVal = false;
    //    }

    //    return retVal;
    //}
    #endregion
}