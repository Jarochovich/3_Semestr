#include <iostream>
#include <Windows.h>
#include <chrono>

using namespace std;

int i = 1;

static void hanoi(int N, int from, int to, int buff)
{
	if (N != 0)
	{
		hanoi(N - 1, from, buff, to);	// переставляем диск из изначального стержня на вспомогательный (конечный), а конечный становится вспомогательным

		cout << "Ход " << i <<" : Диск " << N << " перемещаем из стерженя " << from << " на стержень " << to << endl;
		i++;

		hanoi(N - 1, buff, to, from);	// переставляем диск из вспомогательного стержня на конечный, а изначальный становится вспомогательным
	}
}

int main() 
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	// N - кол-во дисков
	// K - кол-во стержней

	int N, k;
	do
	{
		cout << "Введите кол-во дисков: ";
		cin >> N;
		cout << "Введите кол-во стержней: ";
		cin >> k;
		cout << "\n";

	} while (k < 2 || N < 1);

	
	int from, to, buff;
	do
	{
		cout << "Введите номер начального стержня: ";
		cin >> from;
		cout << "Введите номер конечного стержня: ";
		cin >> to;
		cout << "Введите номер дополнительного стержня: ";
		cin >> buff;
		cout << '\n';

	} while ((from > k || from < 1) || (to > k || to < 1) || (buff > k || buff < 1));
	

	auto begin = chrono::steady_clock::now();

	hanoi(N, from, to, buff);

	auto end = chrono::steady_clock::now();

	auto elapsed_ms = chrono::duration_cast<chrono::milliseconds>(end - begin);

	cout << "\nВремя работы алгоритма: " << elapsed_ms.count() << " ms\n";

	return 0;
}