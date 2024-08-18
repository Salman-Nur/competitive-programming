#include <bits/stdc++.h>
using namespace std;

int main()
{
    int n,t;
    cin >> n >> t;
    if(n == 1 && t == 10)
    {
        cout << -1;
        return 0;
    }
    else if(n == 1)
    {
        cout << t;
        return 0;
    }
    else if(t == 10)
    {
        cout << 1;
        for(int i = 0; i < n-1; i++)
        {
            cout << 0;
        }
    }
    else
    {
        for(int i = 0; i < n; i++)
        {
            cout << t;
        }
    }

    return 0;
}

 