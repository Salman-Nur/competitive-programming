#include<bits/stdc++.h>
using namespace std;
int main()
{
    string str;
    cin >> str;
	for(int i=0; i<str.length(); i++)
	{
	   str[i]=tolower(str[i]);
	}

	for(int j=0; j<str.length(); j++)
    {
        if((str[j]=='a')||(str[j]=='e')||(str[j]=='i')||(str[j]=='o')||(str[j]=='u')||(str[j]=='y'))
        {
            continue;
        }

        else
        {
            cout << "." << str[j];
        }
    }


    return 0;

}