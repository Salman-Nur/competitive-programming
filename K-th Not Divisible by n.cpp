#include<bits/stdc++.h>
using namespace std;

int find_N(int n, int k)
{
    int L = 0, R = 2000000001  ;
    while(L < R)
    {
        int M = L + (R - L) / 2;
        int cnt = M - (M/n);
        if(cnt >= k)
        {
            R = M;
        }
        else
        {
            L = M + 1;
        }
    }

    return L;

}

int main()
{
    int t; cin >> t;
    while(t--)
    {
        int n,k;
        cin >> n >> k;
        cout << find_N(n,k) << "\n";

    }
    return 0;
}