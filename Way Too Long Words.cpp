#include <bits/stdc++.h>

using namespace std;

int main()
{
    string str;
    int n;
    cin >> n;

    for(int i=1; i<=n; i++)
    {
        cin >> str;
        int len = str.size();

        if(len <= 10)
        {
            cout << str << "\n";
        }
        else
        {
            cout << str[0] << len-2 << str[len-1] << "\n";
        }
    }

    return 0;
}