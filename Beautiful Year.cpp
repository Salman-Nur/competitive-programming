#include <bits/stdc++.h>
using namespace std;

int main()
{
    int n;
    cin >> n;
    while(true)
    {
        n = n + 1;
        string str = to_string(n);
        set <char> st;
        for(int i = 0; i < 4; i++)
        {
            st.insert(str[i]);
        }
        if(str.size() == st.size())
        {
            cout << n;
            break;
        }
    }

    return 0;
}