#include <iostream>
#include <windows.h>
#include <vector>
#include <queue>
#include <stack>

using namespace std;

const int INF = 1e9;

// BFS
vector<int> bfs(const vector<vector<int>>& graph, int start) {
    vector<int> dist(graph.size(), INF);
    queue<int> q;
    vector<int> order;

    dist[start] = 0;
    q.push(start);

    while (!q.empty()) {
        int v = q.front();
        q.pop();
        order.push_back(v);

        for (int to : graph[v]) {
            if (dist[to] == INF) {
                dist[to] = dist[v] + 1;
                q.push(to);
            }
        }
    }

    return order;
}

// DFS
vector<int> dfs(const vector<vector<int>>& graph, int start) {
    vector<int> visited(graph.size(), 0);
    stack<int> s;
    vector<int> order;

    s.push(start);

    while (!s.empty()) {
        int v = s.top();
        s.pop();

        if (!visited[v]) {
            visited[v] = 1;
            order.push_back(v);

            for (int to : graph[v]) {
                if (!visited[to]) {
                    s.push(to);
                }
            }
        }
    }

    return order;
}

int main() 
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    int vertexCount = 10;
    vector<pair<int, int>> edges = {
        {1, 2}, {1, 5}, {2, 7}, {5, 6}, {7, 8}, {6, 4}, {8, 3}, {4, 9}, {9, 10}
    };

    // список смежности
    vector<vector<int>> adjList(vertexCount + 1);
    for (auto& edge : edges) {
        adjList[edge.first].push_back(edge.second);
        adjList[edge.second].push_back(edge.first);
    }

    // матрица смежности
    vector<vector<int>> adjMatrix(vertexCount + 1, vector<int>(vertexCount + 1, 0));
    for (auto& edge : edges) {
        adjMatrix[edge.first][edge.second] = 1;
        adjMatrix[edge.second][edge.first] = 1;
    }

    // список рёбер
    vector<pair<int, int>> edgeList = edges;

    int start = 1;

    // ыыполнение BFS и DFS
    vector<int> bfsOrder = bfs(adjList, start);
    vector<int> dfsOrder = dfs(adjList, start);

    // вывод порядка прохождения вершин
    cout << "\nBFS: ";
    for (int v : bfsOrder)
       cout << v << " ";

    cout << endl;

    cout << "\nDFS: ";
    for (int v : dfsOrder)
        cout << v << " ";

    cout << endl;

    // вывод матрицы смежности
    cout << "\nМатрица смежности:" << endl;
    for (int i = 1; i <= vertexCount; ++i) {
        for (int j = 1; j <= vertexCount; ++j) {
            cout << adjMatrix[i][j] << " ";
        }
        cout << endl;
    }

    // вывод списка смежности
    cout << "\nСписок смежности:" << endl;
    for (int i = 1; i <= vertexCount; ++i) {
        cout << i << ": ";
        for (int j : adjList[i]) {
            cout << j << " ";
        }
        cout << endl;
    }

    // вывод списка рёбер
    cout << "\nСписок рёбер:" << endl;
    for (auto& edge : edgeList) {
        cout << edge.first << " - " << edge.second << endl;
    }

    // вывод О большое для различных представлений графа
    cout << "\nО большое для матрицы смежности: O(V^2): " << vertexCount * vertexCount << endl;
    cout << "О большое для списка смежности: O(V + E): " << 21 << endl;
    cout << "О большое для списка рёбер: O(E): " << 11 << endl;

    return 0;
}