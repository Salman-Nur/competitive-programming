#include <bits/stdc++.h>
using namespace std;

int main()
{
    long long a,b,n,s,x,y;
    int t;
    cin >> t;
    while(t--)
    {
        cin >> a >> b >> n >> s;
        x = s / n;
        if(x <= a)
        {
            y = x * n;
        }
        else
        {
            y = a * n;
        }

        if(y + b >= s)
        {
            cout << "YES" << endl;
        }
        else
        {
            cout << "NO" << endl;
        }

    }
    return 0;
}