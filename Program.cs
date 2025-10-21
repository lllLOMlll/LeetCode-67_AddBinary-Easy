﻿using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

public class Solution
{

    public string AddBinary(string a, string b)
    {
        int retainedAddition = 0;
        string result = "";
        int maxLength = Math.Max(a.Length, b.Length);
        int sum = 0;

        a = a.PadLeft(maxLength, '0');
        b = b.PadLeft(maxLength, '0');

        for (int i = maxLength - 1; i >= 0; i--)
        {
            sum = (a[i] - '0') + (b[i] - '0');

            switch (sum)
            {
                case 0:
                    if (retainedAddition > 0)
                    {
                        result += "1";
                        retainedAddition--;
                    }
                    else
                    {
                        result += "0";
                    }
                    break;
                case 1:
                    if (retainedAddition > 0)
                    {
                        result += "0";
                        //retainedAddition--;
                    }
                    else
                    {
                        result += "1";
                    }
                    break;
                case 2:
                    if (retainedAddition > 0)
                    {
                        result += "1";                    
                        break;
                    }
                    else
                    {
                        result += "0";
                        retainedAddition++;
                        break;
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
