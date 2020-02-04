#include <stdio.h>

__declspec(dllexport) int Minus(int firstNumber, int secondNumber)
{
	return firstNumber - secondNumber;
}