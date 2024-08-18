#include <bits/stdc++.h>

using namespace std;

int main()
{
    int n,m,a; cin >> n >> m >> a;
    long long ans = ceil((m+a-1)/a) * ceil((n+a-1)/a);
    cout << ans;

    return 0;
}