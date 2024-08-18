#include <bits/stdc++.h>

using namespace std;

int main()
{
    int n,k;
    cin >> n >> k;
    int arr[n];
    int cnt = 0;

    for(int i=0; i<n; i++)
    {
        cin >> arr[i];
    }

    for(int j=0; j<n; j++)
    {

        if (arr[j] >= arr[k - 1] && arr[j] > 0)
        {
            cnt ++;
        }

    }
    cout << cnt;
    return 0;
}

 