// 1.ImprimirSoma.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include<stdlib.h>

using namespace std;

void ImprimirSoma(int indice);
int main()
{
	int indice = 13;


	cout << "Para " << indice << " elementos" << endl;
    ImprimirSoma(indice);

	system("PAUSE");
	return 0;
}

void ImprimirSoma(int indice) 
{
	int soma = 0;
	int k = 0;
	do
	{
		k += 1; //k++;
		soma += k;
	} while (k < indice);

	cout << "Resultado da soma: " << soma << endl;
}
