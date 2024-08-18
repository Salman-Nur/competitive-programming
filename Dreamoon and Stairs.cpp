#include <bits/stdc++.h>
using namespace std;

int main()
{
    double n,m;
    cin >> n >> m;
    if(m > n)
    {
        cout << -1;
    }
    else
    {
        cout << m*ceil(n/(2*m));
    }
    return 0;
}