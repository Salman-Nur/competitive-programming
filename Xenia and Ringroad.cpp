#include<bits/stdc++.h>
using namespace std;

int main()
{
    int a, b = 1, n, m;
    long long ans = 0;
    cin >> n >> m;
    while(m--)
    {
        cin >> a;
        if(a < b)
        {
            ans += n + a - b;
        }

        else
        {
            ans += a - b;
        }

        b = a;
    }
    cout << ans;
}






 