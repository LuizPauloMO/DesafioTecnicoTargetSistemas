// 4.FaturamentoMensalPorRegiao.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include<stdlib.h>
using namespace std;
#define MAX_REG 4;

class Faturamento
{
public:
	Faturamento() :UF(""), Valor(0.00) {}
	Faturamento(const char* uf, double vl)
	{
		this->UF = uf;
		this->Valor = vl;
	}
	~Faturamento() { delete this; }
	const char* GetUF() const {
		return this->UF;
	}
	double GetValor() const {
		return this->Valor;
	}

	const char* SetUF(const char* UF) {
		this->UF = UF;
	}

	double SetValor(double valor) {
		this->Valor = Valor;
	}
private:
	const char* UF;
	double Valor;
};

double ValorPercentual(double valor, double valorTotal);
int main()
{
	Faturamento* fat[] = { new Faturamento("RJ",36678.66),
						   new Faturamento("SP",67836.43),
						   new Faturamento("MG",29229.88),
						   new Faturamento("MG",29229.88) };

	double faturamento_total = 0.00;
	int qtde = sizeof(fat) / sizeof(fat[0]);

	for (int i = 0; i < qtde; i++) {
		faturamento_total += fat[i]->GetValor();
	}

	printf("Valor total do faturamento: R$%0.2f\n\n", faturamento_total);
	printf("::: PERCENTUAIS POR ESTADO :::\n\n");

	for (int i = 0; i < qtde; i++) {
		printf("%s\tR$%0.2f\t%0.2f%%\n", fat[i]->GetUF(), fat[i]->GetValor(),ValorPercentual(fat[i]->GetValor(),faturamento_total));
	}

	cout << endl;

	system("PAUSE");
	return 0;
	delete fat;
}
double ValorPercentual(double valor, double valorTotal) {
	return valor * 100 / valorTotal;
}