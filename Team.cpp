#include <bits/stdc++.h>

using namespace std;

int main()
{
    int n,x,y,z;
    cin >> n;
    int res = 0;

    for(int i=1; i<=n; i++)
    {
        cin >> x >> y >> z;
        int cnt = 0;

        if(x==1)
        {
            cnt++;
        }
        if(y==1)
        {
            cnt++;
        }
        if(z==1)
        {
            cnt++;
        }
        if(cnt >=2)
        {
            res = res+1;
        }
    }

    cout << res;
    return 0;
}