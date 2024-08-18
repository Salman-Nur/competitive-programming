#include <bits/stdc++.h>
using namespace std;
int main()
{
   int n; cin >> n;
   string str; cin >> str;
   int cnt1 = 0, cnt2 = 0;
   for(int i = 0; i < str.size(); i++)
   {
       if(str[i] == 'A')
       {
           cnt1++;
       }
       else
       {
           cnt2++;
       }
   }
   if(cnt1 > cnt2)
   {
       cout << "Anton";
   }
   else if(cnt1 < cnt2)
   {
       cout << "Danik";
   }
   else
   {
       cout << "Friendship";
   }
    return 0;
}



 