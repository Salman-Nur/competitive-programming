#include <bits/stdc++.h>
using namespace std;
int main()
{
    string str;
    cin >> str;
    vector<char>vec;
    for(int i = 0; i < str.size(); i++)
    {
        if(str[i] == '1')
        {
            vec.push_back('1');
            vec.push_back('+');
        }

    }
    for(int j = 0; j < str.size(); j++)
    {
        if(str[j] == '2')
        {
            vec.push_back('2');
            vec.push_back('+');
        }

    }
    for(int k = 0; k < str.size(); k++)
    {
        if(str[k] == '3')
        {
            vec.push_back('3');
            vec.push_back('+');
        }

    }
    vec.pop_back();
    for(int z=0; z<vec.size(); z++)
    {
        cout << vec[z];
    }
    return 0;
}