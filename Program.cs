using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

public class Solution
{

    public string fillingWithZero(string a, string b)
    {
        string result = "";
        string zeros = "";
        int differenceLenth = Math.Abs(a.Length - b.Length);

        if (a.Length < b.Length)
        {
            for (int k = 0; k < differenceLenth; k++)
            {
                zeros += "0";
            }
            result = zeros + a;
        }
        else
        {
            for (int k = 0; k < differenceLenth; k++)
            {
                zeros += "0";
            }
            result = zeros + b;
        }

        return result;
    }

    public string AddBinary(string a, string b)
    {

        int retainedAddition = 0;
        string result = "";
        int longerLength = Math.Max(a.Length, b.Length);
        int differenceLenth = Math.Abs(a.Length - b.Length);


        if (differenceLenth != 0)
        {
            if (a.Length > b.Length)
            {
                b = fillingWithZero(a, b);
            }
            else
            {
                a = fillingWithZero(a, b);
            }
        }

        for (int i = longerLength - 1; i >= 0; i--)
        {

            if (a[i] == '1' && b[i] == '1')
            {
                if (retainedAddition > 0)
                {
                    result += "1";
                    retainedAddition--;
                }
                else
                {
                    result += "0";
                }
                retainedAddition++;
            }

            // Case 0 et 0 
            if (a[i] == '0' && b[i] == '0')
            {
                if (retainedAddition > 0)
                {
                    result += "1";
                    retainedAddition--;
                }
                else
                {
                    result += "0";
                }

            }

            // Case 1 et 0 ou 0 et 1
            if ((a[i] == '1' && b[i] == '0') || (a[i] == '0' && b[i] == '1'))
            {
                if (retainedAddition > 0)
                {
                    result += "0";
                }
                else
                {
                    result += "1";
                }
            }

            if (i == 0 && retainedAddition > 0)
            {
                result += "1";
            }

        }


        // Inversing the result
        string reservedResult = new string(result.Reverse().ToArray());
        return reservedResult;
    }

    static void Main(string[] args)
    {
        Solution s = new Solution();

        string a1 = "11";
        string b1 = "1";
        string output1 = "100";
        Console.WriteLine(s.AddBinary(a1, b1));
        Console.WriteLine(output1);

        string a1_1 = "1";
        string b1_1 = "11";
        string output1_1 = "100";
        Console.WriteLine(s.AddBinary(a1_1, b1_1));
        Console.WriteLine(output1_1);

        string a2 = "1010";
        string b2 = "1011";
        string output2 = "10101";
        Console.WriteLine(s.AddBinary(a2, b2));
        Console.WriteLine(output2);

        string a3 = "1011";
        string b3 = "1011";
        string output3 = "10110";
        Console.WriteLine(s.AddBinary(a3, b3));
        Console.WriteLine(output3);

        string a4 = "100";
        string b4 = "110010";
        string output4 = "110110";
        Console.WriteLine(s.AddBinary(a4, b4));
        Console.WriteLine(output4);


    }



}
