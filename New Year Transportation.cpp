#include<bits/stdc++.h>
using namespace std;

int main()
{
    int n,a;
    cin >> n >> a;
    int arr[n];
    for(int i=1; i<n; i++)
    {
        cin >> arr[i];
    }

    int cnt = 1;
    while(cnt < a)
    {
        cnt = cnt + arr[cnt];
    }

    if(cnt == a)
    {
        cout << "YES";
    }

    else
    {
        cout << "NO";
    }
    return 0;
}






 