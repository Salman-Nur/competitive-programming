#include <bits/stdc++.h>
using namespace std;
int main()
{
    int n,cnt = 0;
    cin >> n;
    int arr[n];
    int number_of_people, room_capacity;
    for(int i = 0; i < n; i++)
    {
        cin >> number_of_people >> room_capacity;
        if((number_of_people += 2) <= room_capacity)
        {
            cnt++;
        }
    }
    cout << cnt;
    return 0;
}



 