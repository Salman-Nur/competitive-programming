#include <bits/stdc++.h>
using namespace std;

int main()
{
    int n,arr[] = {6,8,4,2};
    cin >> n;
    if(n != 0)
    {
        cout << arr[n%4];
    }
    else
    {
        cout << 1;
    }
    return 0;
}

 