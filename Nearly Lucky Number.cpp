#include <bits/stdc++.h>
using namespace std;
int main()
{
    string str;
    cin >> str;
    vector<char> vec;
    for(int i = 0; i < str.size(); i++)
    {
        if((str[i] == '4') || (str[i] == '7'))
        {
            vec.push_back(str[i]);
        }
    }
    int x = vec.size();
    if((x == 4) || (x == 7))
    {
        cout << "YES";
    }
    else
    {
        cout << "NO";
    }

    return 0;
}