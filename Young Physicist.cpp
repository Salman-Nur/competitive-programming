#include <bits/stdc++.h>
using namespace std;
int main()
{
    int n,x,y,z;
    cin >> n;
    int arr[n];
    int sum1 = 0, sum2 = 0, sum3 = 0;
    for(int i = 0; i < n; i++)
    {
        cin >> x >> y >> z;
        sum1 = sum1 + x;
        sum2 = sum2 + y;
        sum3 = sum3 + z;
    }
    if(sum1 == 0 && sum2 == 0 && sum3 == 0)
    {
        cout << "YES";
    }
    else
    {
        cout << "NO";
    }

    return 0;
}



 