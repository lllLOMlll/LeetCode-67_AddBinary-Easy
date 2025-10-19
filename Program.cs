using System.Collections;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        // Utilise les string length
        // Partir de la fin
        // Utiliser la retenu et la faire suivre (voir 66)
        int retainedAddition = 0;
        int aLength = a.Length;
        int bLength = b.Length;
        string result = "";

        for (int i = a.Length - 1; i >= 0; i--)
        {
            // 1011
            // 1011
            //10110       

            // Cas 1 et 1
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

            // Cas 0 et 0 
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

            // Cas 1 et 0 ou 0 et 1
            if ((a[i] == '1' && b[i] == '0') || (a[i] == '0' && b[i] == '1'))
            {
                if (retainedAddition > 0)
                {
                    result += 0;
                    retainedAddition--;
                }
                else
                {
                    result += 1;
                }
            }

            if (i == 0 && retainedAddition > 0)
            {
                result += 1;
            }

        }


        // Inverser le résultat
        string reservedResult = new string(result.Reverse().ToArray());
        return reservedResult;
    }

    static void Main(string[] args)
    {
        Solution s = new Solution();

        // string a1 = "11";
        // string b1 = "1";
        // string output1 = "100";
        // Console.WriteLine(s.AddBinary(a1, b1));
        // Console.WriteLine(output1);

        // string a2 = "1010";
        // string b2 = "1011";
        // string output2 = "10101";
        // Console.WriteLine(s.AddBinary(a2, b2));
        // Console.WriteLine(output2);
        
        string a3 = "1011";
        string b3 = "1011";
        string output3 = "10110";
        Console.WriteLine(s.AddBinary(a3, b3));
        Console.WriteLine(output3);


    }



}
