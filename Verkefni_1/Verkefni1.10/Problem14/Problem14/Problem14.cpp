// Problem14.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>

using namespace std;

int CollatzSequence(long long int a, int counter = 1) {
	if (a <= 1)
	{
		return counter;
	}
	else
	{
		if (a % 2 == 0)
		{
			a /= 2;
			
		}
		else
		{
			a = (3 * a) + 1;
		}
		counter++;
		CollatzSequence(a, counter);
	}
}


int main()
{
	char stop;
	int length = 0;
	int number = 0;

	for (size_t i = 1; i <= 1000000; i++)
	{
		long int counter = CollatzSequence(i);
		if ( counter > length)
		{
			length  = counter;
			number = i;
		}
	}

	cout << length << endl;
	cout << number << endl;

	cin >> stop;

    return 0;
}

