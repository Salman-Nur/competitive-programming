#include <bits/stdc++.h>
using namespace std;

int main()
{
    int t;
    cin >> t;
    long long x,y,a,b;
    while(t--)
    {
        cin >> x >> y >> a >> b;
        cout << min((x+y) * a, b * min(x,y) + a*abs(x-y))<<endl;
    }

    return 0;
}