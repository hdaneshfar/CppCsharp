#include <stdio.h>
#include <stdbool.h>

bool numberValidation(int number);
__declspec(dllexport) int Minus(int firstNumber, int secondNumber);


__declspec(dllexport) int Minus(int firstNumber, int secondNumber)
{
	if (!numberValidation(firstNumber)) return -1;
	if (!numberValidation(secondNumber)) return -1;

	return firstNumber - secondNumber;
}

bool numberValidation(int number) 
{
	if (number > 0)
	{
		return true;
	}
	else {
		return false;
	}
}