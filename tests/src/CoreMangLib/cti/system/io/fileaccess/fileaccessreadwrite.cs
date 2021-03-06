using System;
using System.IO;

/// <summary>
/// System.IO.FileAccess.ReadWrite
/// </summary>
public class FileAccessReadWrite
{
    static public int Main()
    {
        FileAccessReadWrite test = new FileAccessReadWrite();

        TestLibrary.TestFramework.BeginTestCase("System.IO.FileAccess.ReadWrite");

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

        return retVal;
    }

    public bool PosTest1()
    {

        bool retVal = true;

        const string c_TEST_DESC = "PosTest1:check the FileAccess.ReadWrite value is 3...";
        const string c_TEST_ID = "P001";
        FileAccess FLAG_VALUE = (FileAccess)3;

        TestLibrary.TestFramework.BeginScenario(c_TEST_DESC);

        try
        {

            if (FileAccess.ReadWrite != FLAG_VALUE)
            {
                string errorDesc = "value is not " + FLAG_VALUE.ToString() + " as expected: Actual is " + FileAccess.ReadWrite.ToString();
                TestLibrary.TestFramework.LogError("001" + " TestId-" + c_TEST_ID, errorDesc);
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002" + " TestId-" + c_TEST_ID, "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }


}