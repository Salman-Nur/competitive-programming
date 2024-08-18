#include <bits/stdc++.h>

using namespace std;

int main()
{
    int n,m; cin >> n >> m;
    int x = m*n;
    int cnt = 0;

    for(int a=2; a<=x; a+=2)
    {
        cnt++;
    }
    cout << cnt;

    return 0;
}