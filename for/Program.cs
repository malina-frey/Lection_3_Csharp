﻿/*
for
*/

string method4(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = method4(10, "z");
Console.WriteLine(res);