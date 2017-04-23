// KalkMacierzyLib.h
#include <stddef.h>
#include <stdlib.h>
#include <math.h>
#pragma once


using namespace System;

namespace KalkMacierzyLib {

	public ref class Class1
	{
	public:
		void SumowanieMacierzy(array<int> ^pierwsza, array<int> ^druga, array<int> ^trzecia)
		{
			for (int i = 0; i < 100; i++)
			{
				if (pierwsza[i] != NULL && druga[i] != NULL)
				{
					trzecia[i] = pierwsza[i] + druga[i];
				}
			}

		}
		void OdejmowanieMacierzy(array<int> ^pierwsza, array<int> ^druga, array<int> ^trzecia)
		{
			for (int i = 0; i < 100; i++)
			{
				if (pierwsza[i] != NULL && druga[i] != NULL)
				{
					trzecia[i] = pierwsza[i] - druga[i];
				}
			}

		}
		void MnozenieMacierzy(array<int> ^pierwsza, array<int> ^druga, array<int> ^trzecia, double a, double b, double c, double d)
		{
			for (int i = 0; i < b; i++) {
				for (int j = 0; j < c; j++) {
					float sum = 0.0;
					for (int k = 0; k < d; k++)
						sum = sum + pierwsza[i * a + k] * druga[k * c + j];
					trzecia[i * c + j] = sum;
				}
			}
		};
		int WyznacznikMacierzy(array<int> ^pierwsza, int a)
		{
			int wynik;
			if (a < 1)
			{
				return 0;
			}
			if (a == 1)
			{
				return pierwsza[0];
			}
			if (a == 2)
			{
				return (pierwsza[0] * pierwsza[3]) - (pierwsza[2] * pierwsza[1]);
			}
			if (a == 3)
			{
				return (pierwsza[0] * pierwsza[4] * pierwsza[8]) + (pierwsza[1] * pierwsza[5] * pierwsza[6])
					+ (pierwsza[2] * pierwsza[3] * pierwsza[7]) - (pierwsza[2] * pierwsza[4] * pierwsza[6])
					- (pierwsza[0] * pierwsza[5] * pierwsza[7]) - (pierwsza[1] * pierwsza[3] * pierwsza[8]);
			}
		}

	}
	;
}