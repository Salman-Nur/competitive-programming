#include <bits/stdc++.h>
using namespace std;
int main()
{
    string str1, str2 = "hello";
    cin >> str1;
    int cnt = 0;
    for(int i = 0; i < str1.size(); i++)
    {
        if(str1[i] == str2[cnt])
        {
            cnt++;
        }
    }
    if(cnt == 5)
    {
        cout << "YES";
    }
    else
    {
        cout << "NO";
    }
    return 0;
}
 