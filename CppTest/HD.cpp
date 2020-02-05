#include <stdio.h>
#include <iostream>
using namespace std;

extern "C"
{
	/* function declaration */
	//__declspec(dllexport) int Sum();
	//__declspec(dllexport) int Sum(int firstNumber, int secondNumber);

	int firstNumber;
	int secondNumber;
	

	__declspec(dllexport) void GetFirstNumber()
	{
		cout << "please enter first number : ";
		cin >> firstNumber;
	}

	__declspec(dllexport) void GetSecondNumber()
	{
		cout << "please enter second number : ";
		cin >> secondNumber;
	}

	__declspec(dllexport) void CreateSerialNumber()
	{
		printf("3406gsdmgnm49tnwmfgsd0m \n");
	}


	__declspec(dllexport) int Sum()
	{
		return firstNumber + secondNumber;
	}


	/*__declspec(dllexport) int Sum(int firstNumber, int secondNumber)
	{
		return firstNumber + secondNumber;
	}*/
}