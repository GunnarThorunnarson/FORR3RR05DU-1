// SquereCalculator.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>

using namespace std;

int add(int a, int b) {
	return a + b;
}

int multiply(int a, int b) {
	if (b == 1)
	{
		return a;
	}
	if (b > 1)
	{
		return a + multiply(a, b - 1);
	}
}
int squere(int a) {

	return multiply(a, a);

}




int main()
{
	int tala;
	cout << "Hvaða tölu villtu squerea?" << endl;
	while (cin >> tala)
	{
		cout << "squere(" << tala << ") = " << squere(tala) << endl;
		cout << "Hvaða tölu villtu squerea?" << endl;

	}


    return 0;
}

