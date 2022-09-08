namespace DiamondKataTest;
using ConsoleApplication;

public class UnitTest1
{
    [Fact]

    // TestCase to test Characterlist we are getting from method exactly match with which we are passing here 
    public void TestCaseVerifyGetEqualCharList()
    {
        var letters = new char[26]
        {
                 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        var charList = Program.GetCharList();

        Assert.Equal(letters, charList);
    }

    [Fact]

    // TestCase to test Characterlist we are getting from method exactly not match with which we are passing here 

    public void TestCaseVerifyGetNotEqualCharList()
    {
        var letters = new char[26]
        {
                 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        var charList = Program.GetCharList();

        Assert.NotEqual(letters, charList);
    }


    [Fact]

    // TestCase to test Letter number we are getting from method exactly  match with number we are passing here 

    public void TestCaseVerifyLetterNumberEqualtoNumber()
    {
        var inputChar = 'J';
        var number = "9";

        string letterNum = Program.GetLetterNum(inputChar).ToString();

        Assert.Equal(letterNum, number);
    }

    [Fact]

    // TestCase to test Letter number we are getting from method not exactly  match with number we are passing here 

    public void TestCaseVerifyLetterNumberNotEqualtoNumber()
    {
        var inputChar = 'D';
        var number = "2";

        string letterNum = Program.GetLetterNum(inputChar).ToString();

        Assert.NotEqual(letterNum, number);
    }

    [Fact]

    // TestCase to test Diamond String we are getting from method not match with string we are passing here 

    public void TestCaseVerifyNotEqualDiamondStringl()
    {
        var inputChar = 'D';
        string[] diamondTest = new string[4]{
            "   A",
            "  B B",
            " C   C",
            "D     D", };
        int letterNum = Program.GetLetterNum(inputChar);
        var diamond = Program.ConstructDiamond(letterNum);

        Assert.NotEqual(diamondTest, diamond);
    }

    [Fact]

    // TestCase to test Diamond String we are getting from method exacrtly match with string we are passing here 

    public void TestCaseVerifyEqualDiamondStringl()
    {
        var inputChar = 'D';
        string[] diamondTest = new string[52]{
            "   A",
            "  B B",
            " C   C",
            "D     D",null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,
        null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null};
        int letterNum = Program.GetLetterNum(inputChar);
        var diamond = Program.ConstructDiamond(letterNum);

        Assert.Equal(diamondTest, diamond);
    }
}