// This is the main DLL file.

#include "stdafx.h"

#include "KalkMacierzyLib.h"
//
//extern "C" __declspec(dllexport) void TestowaMetoda(int* pierwsza, int* druga, int* trzecia)
//{
//		for (int i = 0; i < 10; i++)
//		{
//			if (pierwsza[i] != NULL && druga[i] != NULL)
//			{
//				trzecia[i] = pierwsza[i] + druga[i];
//			}
//		}
//}
extern "C" __declspec(dllexport) int ReleaseMemory(int* pArray)
{
	delete[] pArray;
	return 0;
}