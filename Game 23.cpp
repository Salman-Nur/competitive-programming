#include <bits/stdc++.h>
using namespace std;

int main()
{
    int n, m,cnt = 0;
    cin >> n >> m;
    while(n != m)
    {
        if(m%(n*3) == 0)
        {
            n = n * 3;
            cnt++;
        }
        else if(m%(n*2) == 0)
        {
            n = n*2;
            cnt++;
        }
        else
        {
            cnt = -1;
            break;
        }
    }
    cout << cnt;

    return 0;
}