#include <iostream>
#include <Windows.h>
#include <vector>
#include <queue>
#include <chrono>
#include <unordered_map>

using namespace std;

const int INF = 1e9;

unordered_map<char, int> letter_to_index =
{
    {'A', 0}, {'B', 1}, {'C', 2}, {'D', 3}, {'E', 4}, {'F', 5}, {'G', 6}, {'H', 7}, {'I', 8}
};

void dijkstra(const vector<vector<pair<int, int>>>& graph, int start) 
{
    int n = graph.size();
    vector<int> dist(n, INF);
    dist[start] = 0;
    priority_queue<pair<int, int>, vector<pair<int, int>>, greater<pair<int, int>>> pq;
    pq.push({ 0, start });

    while (!pq.empty()) 
    {
        int d = pq.top().first;
        int u = pq.top().second;
        pq.pop();

        if (d > dist[u]) continue;

        for (const auto& edge : graph[u]) 
        {
            int v = edge.first;
            int weight = edge.second;

            if (dist[u] + weight < dist[v]) 
            {
                dist[v] = dist[u] + weight;
                pq.push({ dist[v], v });
            }
        }
    }
    /*(N + E)LOGN*/ 
    cout << "Расстояния от вершины " << letter_to_index[start] << ":\n";
    for (int i = 0; i < n; ++i) 
    {
        if (dist[i] == INF)
            cout << "До вершины " << i << " нет пути\n";
        else
            cout << "До вершины " << i << " = " << dist[i] << "\n";
    }
}

int main() 
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);


   

    vector<vector<pair<int, int>>> graph =
    {
        {{letter_to_index['B'], 7}, {letter_to_index['C'], 10}},                                // A
        {{letter_to_index['A'], 7}, {letter_to_index['F'], 9}, {letter_to_index['G'], 27}},      // B
        {{letter_to_index['A'], 10}, {letter_to_index['E'], 31}, {letter_to_index['F'], 8}},             // C
        {{letter_to_index['E'], 32}, {letter_to_index['H'], 17}, {letter_to_index['I'],21}},             // D
        {{letter_to_index['C'], 31}, {letter_to_index['D'], 32}},                                   // E
        {{letter_to_index['B'], 9}, {letter_to_index['C'], 8}, {letter_to_index['H'], 11}},      // F
        {{letter_to_index['B'], 27}, {letter_to_index['I'], 15}},                                   // G
        {{letter_to_index['D'], 17}, {letter_to_index['F'], 11}, {letter_to_index['I'], 21}},    // H
        {{letter_to_index['G'], 15}, {letter_to_index['D'], 21}}                                // I
    };
    

    char start_letter;
    cout << "Введите стартовую вершину (A-I): ";
    cin >> start_letter;

    int start = letter_to_index[start_letter];

    auto begin = chrono::steady_clock::now();

    dijkstra(graph, start);

    auto end = chrono::steady_clock::now();
    auto elapsed_ms = chrono::duration_cast<chrono::milliseconds>(end - begin);
    cout << "\nВремя работы алгоритма: " << elapsed_ms.count() << " ms\n";

    cout << "О-большое равно: " << "(9 + 11)LOG9: "<< endl; //9 вершин 11 ребер
    return 0;
}