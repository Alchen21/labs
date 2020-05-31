#include "Work.h"
#include <iostream>
#include <limits>
using namespace std;

void Work::w1()
{
	int length;
	int volume;
	int factorial[10] = { 1,2,6,24,120,720,5040,40320,362880,3628800 };
	int index;
	cout << "Enter the length of the cube as a whole number : ";
	cin >> length;
	volume = length * length * length; 
	cout << "The volume is " << volume << endl; 
	cout << "Which factorial do you want ? Enter its index : ";
	cin >> index;
	cout << "Factorial[" << index << "] is " << factorial[index] << endl; 
}

void Work::w2()
{
	int i;
	cout << "For this compiler: " << endl;
	cout << "integers are " << sizeof(int) << " bytes" << endl;
	cout << "largest integer is " << INT_MAX << endl;
	cout << "smallest integer is " << INT_MIN << endl;
	cout << "integers__64 are " << sizeof(__int64) << " bytes" << endl;
	cout << "largest integer is " << _I64_MAX << endl;
	cout << "smallest integer is " << _I64_MIN << endl;
	cout << "Input an integer value " << endl;
	cin >> i;
	cout << endl << "You entered the following value: " << endl;
	cout << "integer: " << i << endl;
}

void Work::w3()
{
	double i;
	double j;
	double result;
	cout << "For this compiler: " << endl;
	cout << "largest double is " << numeric_limits<double>::max() << endl;
	cout << "smallest double is " << numeric_limits<double>::min() << endl;
	cout << "Input two double values " << endl;
	cin >> i >> j;
	cout << endl << "You entered the following values: " << endl;
	cout << "double: " << i << " " << j << endl;

	if (i > numeric_limits<double>::max() / 10 || i < numeric_limits<double>::min() / 10)
		cout << "Your number error" << endl;
	else
	{
		result = i * 10;
		cout << "Your number " << result << endl;
	}

	if (((j > 0) && (i > (numeric_limits<double>::max() - j))) ||
		((j < 0) && (i < (numeric_limits<double>::min() - j))))
		cout << "The sum of your numbers is error" << endl;
	else
	{
		result = i + j;
		cout << "The sum of your numbers is " << result << endl;
	}

	if ((i > 0 && ((j > 0 && i > (numeric_limits<double>::max() / j)) || j < (numeric_limits<double>::min() / i)))
		|| ((j > 0 && i < (numeric_limits<double>::min() / j)) || (i != 0) && (j < (numeric_limits<double>::max() / i))))
		cout << "The product of your numbers is error" << endl;
	else
	{
		result = i * j;
		cout << "The product of your numbers is " << result << endl;
	}
}

void Work::w4()
{
	int i;
	char ch;
	short sh;
	long lon;
	unsigned short us;
	cout << "For this compiler: " << endl;
	cout << "largest integer is " << INT_MAX << endl;
	cout << "smallest integer is " << INT_MIN << endl;
	cout << "size of an integer is " << sizeof(int) << " bytes." << endl;
	cout << "size of a char is " << sizeof(char) << " bytes." << endl;
	cout << "largest short is: " << SHRT_MAX << endl;
	cout << "smallest short is: " << SHRT_MIN << endl;
	cout << "largest unsigned short is: " << USHRT_MAX << endl;
	cout << "largest long is " << LONG_MAX << endl;
	cout << "smallest long is " << LONG_MIN << endl;
	cout << "Input an integer value " << endl;
	cin >> i;
	cout << "Enter a character value " << endl;
	cin >> ch;
	cout << "Enter a short value " << endl;
	cin >> sh;
	cout << "Enter an unsigned short value " << endl;
	cin >> us;
	cout << "Enter a long value " << endl;
	cin >> lon;
	cout << endl << "You entered the following values: " << endl;
	cout << "integer: " << i << endl;
	cout << "character: " << ch << endl;
	cout << "short: " << sh << endl;
	cout << "unsigned short: " << us << endl;
	cout << "long: " << lon << endl;
	cout << "INTEGER OVERFLOW: i = " << INT_MAX + 1 << endl;
	cout << "Ten times short value: sh = " << (sh * 10) << endl;
}

void Work::w5()
{
	signed int a, b;
	cout << "Инфа для компилятора: " << endl;
	cout << "Максимальный INT: " << INT_MAX << endl;
	cout << "Минимальный INT: " << INT_MIN << endl;
	cout << "Введите a: ";
	cin >> a;
	cout << "Введите b: ";
	cin >> b;
	if (a > INT_MAX || a < INT_MIN || b > INT_MAX || b < INT_MIN)
	{
		cout << "Ошибка! Лимит нарушен!" << endl;
	}
	else
	{
		if (((b > 0) && (a > (INT_MAX - b))) ||
			((b < 0) && (a < (INT_MIN - b))))
			cout << "a + b = Ошибка! Лимит нарушен!" << endl;
		else
			cout << "a + b = " << (a + b) << endl;

		if ((a > 0 && ((b > 0 && a > (INT_MAX / b)) || b < (INT_MIN / a)))
			|| ((b > 0 && a < (INT_MIN / b)) || (a != 0) && (b < (INT_MAX / a))))
			cout << "a * b = Ошибка! Лимит нарушен!" << endl;
		else
			cout << "a * b = " << (a * b) << endl;

		if ((b == 0) || ((a == INT_MIN) && (b == -1)))
			cout << "a / b = Ошибка! Лимит нарушен!" << endl;
		else
			cout << "a / b = " << (a / b) << endl;
	}
}