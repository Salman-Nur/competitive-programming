#include <bits/stdc++.h>
using namespace std;
int main()
{
    int k,n,w,cost = 0;
    cin >> k >> n >> w;
    for(int i = 1; i <= w; i++)
    {
        cost = cost + i*k;
    }

    if(cost > n)
    {
        int borrow = cost - n;
        cout << borrow;
    }
    else
    {
        cout << 0;
    }
    return 0;
}