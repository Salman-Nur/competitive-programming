#include <bits/stdc++.h>
using namespace std;
int main()
{
    int d;
    cin >> d;
    int number_of_step = 0;
    for(int i = 0; i < d; i+= 5)
    {
        number_of_step++;
    }
    cout << number_of_step;
    return 0;
}