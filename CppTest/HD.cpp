#include <stdio.h>

extern "C" 
{
	/* function declaration */
	//__declspec(dllexport) int Sum(int firstNumber, int secondNumber);

	__declspec(dllexport) void DisplayHelloFromDLL()
	{
		printf("Hello from DLL !\n");
	}

	__declspec(dllexport) void CreateSerialNumber()
	{
		printf("3406gsdmgnm49tnwmfgsd0m \n");
	}


	__declspec(dllexport) int Sum(int firstNumber, int secondNumber)
	{
		return firstNumber + secondNumber;
	}
}