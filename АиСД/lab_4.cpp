#include <iostream>
#include <Windows.h>
#include <vector>
#include <limits>
#include <chrono>

using namespace std;

const int INF = 1e9;

void printMatrix(const vector<vector<int>>& matrix)
{
    for (const auto& row : matrix)
    {
        for (int val : row)
        {
            if (val == INF)
                cout << "INF ";
            else
                cout << val << " ";
        }
        cout << endl;
    }
}

void floydWarshall(vector<vector<int>>& distD, vector<vector<int>>& next)
{
    int V = distD.size();

    for (int k = 0; k < V; ++k)
    {
        for (int i = 0; i < V; ++i)
        {
            for (int j = 0; j < V; ++j)
            {
                if (distD[i][k] != INF && distD[k][j] != INF && distD[i][k] + distD[k][j] < distD[i][j])
                {
                    distD[i][j] = distD[i][k] + distD[k][j];
                    next[i][j] = next[i][k];
                }
            }
        }
    }
}

void printPath(const vector<vector<int>>& next, int start, int end)
{
    if (next[start][end] == INF)
    {
        cout << "Пути нет" << endl;
        return;
    }
    vector<int> path;
    path.push_back(start);
    while (start != end)
    {
        start = next[start][end];
        path.push_back(start);
    }
    for (int v : path)
    {
        cout << v + 1 << " ";
    }
    cout << endl;
}

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    vector<vector<int>> graphD = {
        {0, 28, 21, 59, 12, 27},
        {7, 0, 24, INF, 21, 9},
        {9, 32, 0, 13, 11, INF},
        {8, INF, 5, 0, 16, INF},
        {14, 13, 15, 10, 0, 22},
        {15, 18, INF, INF, 6, 0}
    };

    vector<vector<int>> next = {
        {0, 1, 2, 3, 4, 5},
        {0, 1, 2, 3, 4, 5},
        {0, 1, 2, 3, 4, 5},
        {0, 1, 2, 3, 4, 5},
        {0, 1, 2, 3, 4, 5},
        {0, 1, 2, 3, 4, 5}
    };

    vector<vector<int>> distD = graphD;

    cout << "Исходная матрица расстояний (D0):" << endl;
    printMatrix(graphD);

    auto begin = chrono::steady_clock::now();

    floydWarshall(distD, next);

    auto end = chrono::steady_clock::now();
    auto elapsed_ms = chrono::duration_cast<chrono::milliseconds>(end - begin);

    cout << "Матрица кратчайших путей (D):" << endl;
    printMatrix(distD);


    int start, endVertex;
    cout << "Введите начальную вершину: ";
    cin >> start;
    cout << "Введите конечную вершину: ";
    cin >> endVertex;
   

    cout << "Кратчайший путь от " << start << " до " << endVertex << ": ";
    printPath(next, --start, --endVertex);

    cout << "\nВремя работы алгоритма Флойда - Уоршелла: " << elapsed_ms.count() << " ms" << endl;
    cout << "О-большое O(V^3): " << pow(6, 3) << endl;

    return 0;
}