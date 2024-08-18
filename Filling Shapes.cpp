#include <bits/stdc++.h>
using namespace std;

int main()
{
    int n,x;
    cin >> n;
    if(n % 2 == 0)
    {
        x = pow(2,n/2);
        cout << x;
    }
    else
    {
        cout << 0;
    }

    return 0;
}