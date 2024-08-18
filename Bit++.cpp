#include <bits/stdc++.h>

using namespace std;

int main()
{
    int t,x = 0;
    cin >> t;
    string str;

    while(t--)
    {
        cin >> str;

        if((str == "X++") || (str == "++X"))
        {
            x = x + 1;
        }
        else
        {
            x = x - 1;
        }
    }

    cout << x;
    return 0;
}