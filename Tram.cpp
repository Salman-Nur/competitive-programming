#include <bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    cin >> n;
    int enter,exit,number_of_passenger = 0;
    set<int>st;
    for(int i = 1; i <= n; i++)
    {
        cin >> exit >> enter;
        number_of_passenger = (number_of_passenger - exit) + enter;
        st.insert(number_of_passenger);
    }
    auto it = st.rbegin();
    cout<<*it;
    return 0;
}