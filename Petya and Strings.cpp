#include<bits/stdc++.h>
using namespace std;

int main()
{
    string str1,str2;
    cin >> str1 >> str2;
	for(int i=0; i<str1.length(); i++)
	{
	   str1[i]=tolower(str1[i]);
	}

    for(int j=0;j<str2.length();j++)
    {
        str2[j]=tolower(str2[j]);
    }
    if(str1 == str2)
    {
        cout << "0";
    }
    else if(str1 < str2)
    {
        cout << "-1";
    }
    else
    {
        cout << "1";
    }

    return 0;

}