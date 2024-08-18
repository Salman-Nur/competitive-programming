#include <bits/stdc++.h>
using namespace std;
int main()
{
    int n; cin >> n;
    int arr[n];
    set<int>st;
    for(int i = 0; i < n; i++)
    {
        cin >> arr[i];
        if(arr[i] == 1)
        {
            st.insert(1);
        }
    }
    if(st.size() == 1)
    {
        cout << "HARD";
    }
    else
    {
        cout << "EASY";
    }
    return 0;
}



 