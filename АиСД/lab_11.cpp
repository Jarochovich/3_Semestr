#include <iostream>
#include <windows.h>
#include <algorithm>
#include <random>
#include <ctime>

using namespace std;

#define COUNT_PRISONER 100

struct Box 
{
    int numberBox;
    int innerNumberBox;
};

bool RandomWay(int prisoner[], Box box[]) 
{
    for (int i = 0; i < COUNT_PRISONER; i++) 
    {
        int step = 0;
        bool found = false;

        while (step < 50)
        {
            int randomBox = rand() % COUNT_PRISONER;
            if (box[randomBox].innerNumberBox == prisoner[i]) 
            {
                found = true;
                break;
            }
            step++;
        }
        if (!found) 
        {
            return false;
        }
    }
    return true;
}

bool SelectingNumberBox(int prisoner[], Box box[]) 
{
    for (int i = 0; i < COUNT_PRISONER; i++) 
    {
        int currentBox = prisoner[i];
        for (int j = 0; j < 50; j++) 
        {
            if (box[currentBox].innerNumberBox == prisoner[i]) 
            {
                break;
            }
            currentBox = box[currentBox].innerNumberBox;
        }
        if (box[currentBox].innerNumberBox != prisoner[i]) 
        {
            return false;
        }
    }
    return true;
}

int main() 
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    srand(time(0));

    int numRounds;
    cout << "Введите количество раундов: ";
    cin >> numRounds;

    // Cчетчики
    int randomSuccess = 0;
    int loopSuccess = 0;

    for (int round = 0; round < numRounds; round++) 
    {
        int prisoner[COUNT_PRISONER] = {};
        Box box[COUNT_PRISONER] = {};

        // Заполняем массив номеров заключенных
        // Заполняем номера коробок
        for (int i = 0; i < COUNT_PRISONER; i++)
        {
            prisoner[i] = i;
            box[i].numberBox = i;
        }

        // Заполняем номерки в самих коробочках
        for (int i = 0; i < COUNT_PRISONER; i++) 
        {
            box[i].innerNumberBox = i;
        }

        // Перемешиваем массив номерки в коробочках
        for (int i = 0; i < COUNT_PRISONER; i++)
        {
            int randomIndex = rand() % COUNT_PRISONER;
            swap(box[i].innerNumberBox, box[randomIndex].innerNumberBox);
        }


        if (RandomWay(prisoner, box)) 
        {
            randomSuccess++;
        }
        if (SelectingNumberBox(prisoner, box))
        {
            loopSuccess++;
        }
    }

    cout << "Случайным способом: " << randomSuccess << endl;
    cout << "Выбором номера в коробке: " << loopSuccess << endl;

    return 0;
}