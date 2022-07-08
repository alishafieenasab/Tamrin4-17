Console.WriteLine("Hello, World!");


//void oneTwo(string aString)
//{
//    Array.
//    for (int i = 0; i < aString.Length; i++)
//    {
//        for(int j = 0; j < aString.Length; j++)
//    }
//}


//----------------Part2---------------

Console.WriteLine(shareDigit(10, 20));

bool shareDigit(int aDigit1, int aDigit2)
{
    bool a = false;
    bool b = false;
    bool result = false;
    string digit1 = aDigit1.ToString();
    string digit2 = aDigit2.ToString();
    if(aDigit1 >= 10 && aDigit1 <= 99)
        a = true;
    if(aDigit2 >= 10 && aDigit2 <= 99)
        b = true;
    if(a && b)
    {
        for(int i = 0; i < digit1.Length; i++)
        {
            for(int j = 0; j < digit2.Length; j++)
            {
                if(digit1[i] == digit2[j])
                    result = true;
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid Integers");
    }
    return result;
}

//--------------------Part3------------------

Console.WriteLine(sumLimit(3 , 8));

int sumLimit(int aDigit1, int aDigit2)
{
    int sum = 0;
    sum = aDigit1 + aDigit2;
    string digit1 = aDigit1.ToString();
    string sSum = sum.ToString();
    if(sSum.Length > digit1.Length)
    {
        return aDigit1;
    }
    else
    {
        return sum;
    }
}
