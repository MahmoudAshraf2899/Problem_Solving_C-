///Explanation
/* 
Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
 */

bool IsPalindrome(int x)
{
    #region V3 : Approved
    string str = x.ToString(); //Turn to string (easy to reverse)
    char[] charArr = str.ToCharArray();  //Convert To Array Of Char
    char[] reversedArr = str.ToCharArray();// Convert Again To Compare between two results before reverse and after
   
    Array.Reverse(reversedArr);
     
    return charArr.SequenceEqual(reversedArr); //compare two arrays

    #endregion

    #region V2 : Rejected
    //string convertedNumber = x.ToString();
    //string firstChar = convertedNumber[0].ToString();
    //string lastChar = convertedNumber[convertedNumber.Length - 1].ToString();
    //string middle = convertedNumber.Substring(1, convertedNumber.Length - 2);

    //string readFromRight = lastChar + middle + firstChar;
    //string readFromLeft = firstChar + middle + lastChar;
    //if (readFromRight == readFromLeft)
    //{
    //    return true;
    //}
    //return false;
    #endregion
    #region V1 : Rejected
    //string result = x.ToString();
    //var firstElement =  result.FirstOrDefault().ToString();
    //var lastElement = result.LastOrDefault().ToString(); 
    //if(firstElement == lastElement)
    //{
    //    return true;
    //}
    //return false; 
    #endregion
}

IsPalindrome(0);

