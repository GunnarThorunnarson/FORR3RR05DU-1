// squereRootCalculator.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>

using namespace std;



double calculus(double x, double S) {

	double x2 = 0.5 * (x + (S / x));

	if (x == x2)
	{
		return x2;
	}
	else
	{
		calculus(x2, S);
	}
}

double squereRoot(double S) {
	int length = S;
	int digits = 0;
	do { 
		length /= 10; 
		digits++; 
	} while (length != 0);
	double x = digits * (10 * 10);
	return calculus(x, S);


}


int main()
{
	char stop;
	double S;
	cout << "What number do you want to get the squere root of? " << endl;
	cin >> S;
	cout << "The squere root of " << S << " is = " << squereRoot(S) << endl;
	cin >> stop;


    return 0;
}

