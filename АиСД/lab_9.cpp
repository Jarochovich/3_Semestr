#include <iostream>
#include <vector>
#include <algorithm>
#include <Windows.h>
#include <random>
#include <time.h>

using namespace std;

#define START_FROM 0

namespace Genetic 
{
    int random(int min, int max)
    {
        std::random_device rd;
        std::mt19937 gen(rd());
        std::uniform_int_distribution<int> distribution(min, max);

        return distribution(gen);
    }

    void customSort(std::vector<std::vector<int>>& gens, std::vector<int>& weights)
    {
        // Создаем вспомогательный вектор пар (индекс, значение)
        std::vector<std::pair<int, int>> pairs;
        for (int i = 0; i < weights.size(); ++i) 
        {
            pairs.emplace_back(i, weights[i]);
        }

        // Сортируем пары по значениям weights
        std::sort(pairs.begin(), pairs.end(), [](const auto& a, const auto& b)
        {
            return a.second < b.second;
        });

        // Создаем временные векторы для хранения отсортированных значений
        std::vector<std::vector<int>> sortedGens(gens.size(), std::vector<int>(gens[0].size()));
        std::vector<int> sortedWeights(weights.size());

        // Переносим значения в соответствии с отсортированным порядком weights
        for (int i = 0; i < weights.size(); ++i) 
        {
            int originalIndex = pairs[i].first;
            sortedWeights[i] = pairs[i].second;
            sortedGens[i] = gens[originalIndex];
        }

        // Обновляем входные массивы
        weights = sortedWeights;
        gens = sortedGens;
    }

    void printPopulation(vector<int> population, int distance)
    {
        for (auto elem : population) 
        {
            cout << elem << " ";
        }

        cout << "  |  " << distance << "\n";
    }

    long wayLen(vector<int> way, vector<vector<int>> a) 
    {
        long wayLong = 0;
        for (int i = 1; i < way.size(); i++)
        {
            wayLong += a[way[i - 1]][way[i]];
        }

        return wayLong;
    }

    void mutate(vector<int>& genom, int& distance, vector<vector<int>>& a)
    {
        int v1 = random(1, genom.size() - 2);
        int v2 = random(1, genom.size() - 2);

        swap(genom[v1], genom[v2]);
        distance = wayLen(genom, a);
    }

    pair<vector<vector<int>>, vector<int>> GeneratePopulation(int size, int ECount, vector<vector<int>>& a)
    {
        vector<vector<int>> population(size, vector<int>(ECount + 1, 0));
        vector<int> distance(size, 0);

        for (int i = 0; i < ECount; i++) 
        {
            if (i != START_FROM)
                population[0][i] = i;
        }

        population[0][0] = START_FROM;
        population[0][ECount] = START_FROM;

        for (int i = 1; i < size; i++) 
        {
            population[i] = population[i - 1];
            bool valid = false;

            while (!valid) 
            {
                random_shuffle(++population[i].begin(), population[i].end() - 1);
                long len = Genetic::wayLen(population[i], a);
                if (len <= INT_MAX) 
                {
                    distance[i] = len;
                    valid = true;
                }
            }
        }

        distance[0] = Genetic::wayLen(population[0], a);

        return make_pair(population, distance);
    }


    vector<int> Сrossbreeding(vector<int> gen1, vector<int> gen2) 
    {
        std::vector<int> newGen;
        std::vector<bool> taken(gen1.size(), false); // Массив для отслеживания взятых элементов

        int length = gen1.size();
        int crossoverPoint = rand() % length;

        newGen.push_back(START_FROM);
        taken[START_FROM] = true;

        for (int i = 1; i < crossoverPoint; ++i)
        {
            newGen.push_back(gen1[i]);
            taken[gen1[i]] = true;
        }

        for (int i = crossoverPoint; i < length - 1; ++i)
        {
            if (!taken[gen2[i]]) 
            {
                newGen.push_back(gen2[i]);
                taken[gen2[i]] = true;
            }
        }

        // Добавление недостающих элементов из второго родителя
        for (int i = 1; i < length - 1; ++i) 
        {
            if (!taken[gen2[i]]) 
            {
                newGen.push_back(gen2[i]);
                taken[gen2[i]] = true;
            }
        }

        newGen.push_back(START_FROM);

        return newGen;
    }


    void printMatrix(const vector<vector<int>>& matrix) 
    {
        for (const auto& row : matrix) 
        {
            for (const auto& elem : row)
            {
                if (elem == INT_MAX)
                {
                    cout << "INF "; // Для обозначения "бесконечности"
                }
                else {
                    cout << elem << " ";
                }
            }
            cout << endl;
        }
        cout << endl;
    }

    void printVector(const vector<int>& vec)
    {
        for (const auto& elem : vec) 
        {
            cout << elem << " ";
        }
        cout << endl;
    }

    void StartGeneticAlgo(vector<vector<int>>& a, int startPopulationSize, int sonsCount, int evolutionsCount, int mutation_precentage)
    {
        pair<vector<vector<int>>, vector<int>> ans = Genetic::GeneratePopulation(startPopulationSize, a.size(), a);

        vector<vector<int>> populations = ans.first;
        vector<int> lenghts = ans.second;

        printMatrix(populations);
        printVector(lenghts);

        for (int t = 0; t < evolutionsCount; t++) 
        {
            vector<vector<int>> newPopulation;
            vector<int> newLenghts;

            for (int i = 0; i < sonsCount; i++) 
            {
                int daddyIndex = random(0, populations.size() - 1);
                int momyIndex = random(0, populations.size() - 1);

                do 
                {
                    momyIndex = random(0, populations.size() - 1); // regenarate while
                } while (momyIndex == daddyIndex);


                newPopulation.push_back(Сrossbreeding(populations[daddyIndex], populations[momyIndex]));
                newLenghts.push_back(wayLen(newPopulation[newPopulation.size() - 1], a));


                bool doMutation = random(0, 1) < (mutation_precentage);
                if (doMutation)
                    mutate(newPopulation[newPopulation.size() - 1], newLenghts[newLenghts.size() - 1], a);
            }


            for (int i = 0; i < newPopulation.size(); i++) 
            {
                populations.push_back(newPopulation[i]);
                lenghts.push_back(newLenghts[i]);
            }


            customSort(populations, lenghts);

            populations.erase(populations.end() - newPopulation.size(), populations.end()); // !!! newPopulation.size() РАВНО sonsCount
            lenghts.erase(lenghts.end() - newPopulation.size(), lenghts.end());


            cout << "-------------------------------------------\n";
            cout << "\t\t STEP " << t + 1 << " \t\t\n";

            cout << "Минимальный маршрут: ";
            printVector(populations[0]);

            cout << "Его длина: ";
            cout << (lenghts[0]) << "\n";


            for (int q = 0; q < populations.size(); q++) 
            {
                printPopulation(populations[q], lenghts[q]);
            }
        }


    }

}


// Пути (все ведут в Рим)
vector<vector<int>> a = { {0, 10, 15, 20, 25, 30, 35, 40, 45, 50},
                          {10, 0, 12, 18, 22, 28, 33, 38, 43, 48},
                          {15, 12, 0, 13, 17, 23, 28, 33, 38, 43},
                          {20, 18, 13, 0, 15, 20, 25, 30, 35, 40},
                          {25, 22, 17, 15, 0, 10, 15, 20, 25, 30},
                          {30, 28, 23, 20, 10, 0, 10, 15, 20, 25},
                          {35, 33, 28, 25, 15, 10, 0, 11, 15, 20},
                          {40, 38, 33, 30, 20, 15, 11, 0, 10, 15},
                          {45, 43, 38, 35, 25, 20, 15, 10, 0, 12},
                          {50, 48, 43, 40, 30, 25, 20, 15, 12, 0},
};

int n = a.size();


void replaceZerosToINT_MAX(vector<vector<int>>& a) 
{
    for (int i = 0; i < a.size(); i++) 
    {
        for (int j = 0; j < a[i].size(); j++)
        {
            if (a[i][j] == 0) 
            {
                a[i][j] = INT_MAX;
            }
        }
    }

}


void menu() 
{
    cout << "1) Добавить вершину\n";
    cout << "2) Добавить ребро\n";
    cout << "3) Начать алгоритм\n";
    cout << "4) Удалить вершину\n";
    cout << "5) Удалить ребро\n";

    int choice;
    cin >> choice;

    switch (choice)
    {
    case 1:
    {
        for (int i = 0; i < a.size(); ++i)
        {
            a[i].push_back(0);
        }

        vector<int> newRow(a[0].size(), 0);
        a.push_back(newRow);
        Genetic::printMatrix(a);
    }

    menu();
    break;
    case 2:
    {
        cout << "Введите номера вершин для ребра и его вес: ";
        int from, to, weight;

        cin >> from >> to >> weight;

        int vertices = a.size();

        if (from >= vertices || to >= vertices || from < 0 || to < 0)
        {
            cout << "Ошибка: Недопустимые вершины!" << endl;
            return;
        }

        a[from][to] = weight;
    }

    Genetic::printMatrix(a);

    menu();
    break;
    case 3:
    {
        int startPopulationSize;
        int sonsCount;
        int evolutionsCount;
        int mutation_precentage;

        cout << "Введите начальный размер популяции: ";
        cin >> startPopulationSize;

        cout << "Введите количество потомков при скрещивании: ";
        cin >> sonsCount;

        cout << "Введите количество эволюций: ";
        cin >> evolutionsCount;

        cout << "Введите процент мутации: ";
        cin >> mutation_precentage;

        replaceZerosToINT_MAX(a);

        Genetic::StartGeneticAlgo(a, startPopulationSize, sonsCount, evolutionsCount, mutation_precentage);

        break;
    }
    case 4:
    {
        Genetic::printMatrix(a);
        cout << "Введите вершину для удаления (x, y):\n";
       
        int from, to;

        cin >> from >> to;

        int vertices = a.size();

        if (from >= vertices || to >= vertices || from < 0 || to < 0)
        {
            cout << "Ошибка: Недопустимые вершины!" << endl;
            return;
        }

        a[from][to] = 0;

        Genetic::printMatrix(a);
    }
    menu();
    break;
    case 5:
    {
        Genetic::printMatrix(a);
        cout << "Введите ребро для удаления (x, y):\n";

        int from, to;

        cin >> from >> to;

        int vertices = a.size();

        if (from >= vertices || to >= vertices || from < 0 || to < 0)
        {
            cout << "Ошибка: Недопустимые вершины!" << endl;
            return;
        }

        a[from][to] = 0;

        Genetic::printMatrix(a);
    }
    menu();
    break;
    }
}


int main() 
{
    setlocale(LC_ALL, "Rus");
    menu();

    return 0;
}
