// 2.Fibonacci.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include<stdlib.h>

using namespace std;
#define MAX_FIBONACCI 7

int* GerarFibonacci();

int main()
{
	int* fb = GerarFibonacci();
	int num;

	cout << "Digite um numero:";
	cin >> num;
	cout << "::: SEQUENCIA FIBONACCI :::" << endl;
	for (int i = 0; i <= MAX_FIBONACCI; i++) {
		printf("%2d - ",fb[i]);
	}
	cout<<endl;

	for (int i = 0; i <= MAX_FIBONACCI;i++) {
		if (fb[i]==num) {
			cout << "Valor digitado encontrado na lista de Fibonacci" << endl;
			break;
		}
	}

	system("PAUSE");	
	return 0;

}

int* GerarFibonacci() 
{
	int*fb=new int[MAX_FIBONACCI];
	int i = 1;
	int j = 0;
	for (int n = 0; n <= MAX_FIBONACCI;n++) {
		int k = i + j;
		i = j;
		j = k;	
		fb[n] = i;
	}
	return fb;
	
}
