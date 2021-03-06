using System;
using System.Globalization;
/// <summary>
///Constructor(string)
/// </summary>
public class CultureInfoConstructor2
{
    public static int Main()
    {
        CultureInfoConstructor2 CultureInfoConstructor2 = new CultureInfoConstructor2();

        TestLibrary.TestFramework.BeginTestCase("CultureInfoConstructor2");
        if (CultureInfoConstructor2.RunTests())
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
        retVal = PosTest3() && retVal;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = NegTest1() && retVal;
        retVal = NegTest2() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: CultureTypes.NeutralCultures.");
        try
        {
            CultureInfo myCulture = new CultureInfo("en");
			//SL now support neutral cultures
            if (!(myCulture is CultureInfo))
            {
                TestLibrary.TestFramework.LogError("001", "should return 'en' CultureInfo.");
                retVal = false;
            }
        }
        catch (ArgumentException)
        {
			// ArgumentException is not expected on Windows either
			TestLibrary.TestFramework.LogError("001.1", "Expect no exception instead got ArgumentException");
            retVal = false;
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest2()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest2: CultureTypes.SpecificCultures.");
        try
        {
            CultureInfo myCulture = new CultureInfo("fr-FR");
            if (!(myCulture is CultureInfo))
            {
                TestLibrary.TestFramework.LogError("003", "should return 'ar-SA' CultureInfo.");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("004", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest3()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest3: CultureInfo.InvariantCulture.");
        try
        {
            CultureInfo myCulture = new CultureInfo("");
            if (!(myCulture is CultureInfo))
            {
                TestLibrary.TestFramework.LogError("005", "should return InvariantCulture CultureInfo.");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("006", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool NegTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("NegTest1: culture is less than zero.");
        try
        {
            CultureInfo myCulture = new CultureInfo(null);
            TestLibrary.TestFramework.LogError("007", "ArgumentNullException should be caught.");
            retVal = false;
           
        }
        catch (ArgumentNullException)
        {
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("008", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool NegTest2()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("NegTest2: culture is not a valid culture identifier.");
        try
        {
            CultureInfo myCulture = new CultureInfo("Hello");
			if (TestLibrary.Utilities.IsWindows)
			{
				TestLibrary.TestFramework.LogError("009", "ArgumentException should be caught.");
				retVal = false;
			}

        }
        catch (ArgumentException)
        {
			if (!TestLibrary.Utilities.IsWindows)
			{
				TestLibrary.TestFramework.LogError("009", "ArgumentException should not be caught on MAC.");
				retVal = false;
			}

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("010", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
}

