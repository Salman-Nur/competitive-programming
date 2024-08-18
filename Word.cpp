#include <bits/stdc++.h>
using namespace std;
int main()
{
    string str;
    cin >> str;
    int cnt1 = 0;
    int cnt2 = 0;

    for(int i = 0; i < str.size(); i++)
    {
        if((str[i] >= 65) && (str[i] <= 90))
        {
            cnt1++;
        }
        else
        {
            cnt2++;
        }
    }
    if(cnt1 > cnt2)
    {
        for(int j = 0; j < str.size(); j++)
        {
            str[j] = toupper(str[j]);
        }
        cout << str;
    }
    else
    {
        for(int k = 0; k < str.size(); k++)
        {
            str[k] = tolower(str[k]);
        }
        cout << str;
    }
    return 0;
}