// See https://aka.ms/new-console-template for more information
/*
I= 1
V=5
X=10
L=50
C=100
D=500
M=1000

1 = I
2=II
3=III
-----------------
10 =X,
20=XX,
30=XXX,
-----------------
100 = C,
200=CC,
300=CC
-----------------
1000=M,
2000=MM,
3000=MMM
-----------------
IV = 4  =>(5-1)
V=5
VI=6 (5+1)
VIII=8 (5+1+1+1)
VX =5 =>(10-5)=>V
IX = 9 =>(10-9)
XL=40 =>(50-10)
XC = 90 =>(100-10)
CM = 900 => (1000-100

)

IF WE WANT TO GET NUMBER 49

FIRST GET NUMBER 40
SECOND GET NUMBER 9.
 40 = XL (50-10)
 9 = IX
 49 = XLIX


WHAT IS THE RESULT OF THIS (LVIII)?
58
EXPLANATION
VIII = 8
L=50
LVIII=58


*/

Dictionary<char, int> RomanNumeralValues = new Dictionary<char, int>();
RomanNumeralValues.Add('I', 1);
RomanNumeralValues.Add('V', 5);
RomanNumeralValues.Add('X', 10);
RomanNumeralValues.Add('L', 50);
RomanNumeralValues.Add('C', 100);
RomanNumeralValues.Add('D', 500);
RomanNumeralValues.Add('M', 1000);


List<int> result= new List<int>();
int RomanToInt(string s)
{

    #region V2 : Approved
    char[] ch = s.ToCharArray();

    int result = 0;
    int intVal, nextIntVal;

    for (int i = 0; i < ch.Length; i++)
    {
        intVal = RomanNumeralValues[ch[i]];//Get Value  Element

        if (i != ch.Length - 1)
        {
            nextIntVal = RomanNumeralValues[ch[i + 1]]; //Get Next Value

            if (nextIntVal > intVal)
            {
                intVal = nextIntVal - intVal;
                i = i + 1;
            }
        }
        result = result + intVal;
    }
    return result;

    #endregion

    #region V1:REJECTED
    //char[] array = s.ToCharArray();
    //foreach (var item in array)
    //{

    //    var valueOfCharInRoman = RomanNumeralValues.FirstOrDefault(c => c.Key == item.ToString()).Value;
    //    result.Add(valueOfCharInRoman);
    //}
    //var finalResult = result.Sum(c => c);
    //return finalResult; 
    #endregion
}

RomanToInt("MCMXCIV"); //1994
