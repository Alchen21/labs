#include <stdio.h>
#include <iostream>
#include "Work.h"
using namespace std;

int main()
{
	int n;
	setlocale(LC_ALL, "rus");
	cout << "Номер задания: ";
	cin >> n;
	switch (n)
	{
	case 1: 
		Work::w1();
		break;
	case 2: 
		Work::w2();
		break;
	case 3: 
		Work::w3();
		break;
	case 4:
		Work::w4();
		break;
	case 5:
		Work::w5();
		break;
	default: 
		cout << "Несуществующее задание" << endl;
	}
	system("pause");
	return 0;
}


