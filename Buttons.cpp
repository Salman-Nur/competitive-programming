#include <bits/stdc++.h>
using namespace std;

int main()
{
    int n, x = 0;
    cin >> n;
    for(int i = 1; i < n; i++)
    {
        x += (n - i) * i;
    }
    cout << x + n;

    return 0;
}