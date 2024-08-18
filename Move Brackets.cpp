#include <bits/stdc++.h>
using namespace std;

int main()
{
    int t;
    cin >> t;
    string str;
    while(t--)
    {
        int n,cnt1 = 0,cnt2 = 0;
        cin >> n;
        cin >> str;
        for(int i = 0; i < n; i++)
        {
            if(str[i] == '(')
            {
                cnt1++;
            }
            else if(cnt1 > 0)
            {
                cnt1--;
            }
            else
            {
                cnt2++;
            }
        }
        cout <<  cnt2 << endl;

    }
    return 0;
}
