#include <iostream>
#include <vector>
#include <cmath>
#include <limits>
#include <cstdlib>
#include <ctime>

using namespace std;

const int MAX_CITIES = 100;     // Максимальное кол-во городов
const double EVAPORATION = 0.5; // Коэффициент испарения феромонов
const double Q = 100.0;         // Константа для обновления феромонов

struct City
{
    int x;
    int y;
};

double distance(const City& a, const City& b) 
{
    return sqrt(pow(a.x - b.x, 2) + pow(a.y - b.y, 2));
}

void initialize_pheromones(vector<vector<double>>& pheromones, int n) 
{
    cout << "Введите начальные значения феромонов для каждого ребра:" << endl;
    for (int i = 0; i < n; ++i) 
    {
        for (int j = i + 1; j < n; ++j) 
        {
            cout << "Феромоны между городами " << i << " и " << j << ": ";
            cin >> pheromones[i][j];
            pheromones[j][i] = pheromones[i][j]; // Матрица 
        }
    }
}


int main()
{
    setlocale(LC_ALL, "Rus");
    srand(time(0));

    int N;
    do
    {
        cout << "Введите количество городов ([1;" << MAX_CITIES << "]): ";
        cin >> N;
    } while (N > MAX_CITIES || N < 1);

    vector<City> cities(N);
    vector<vector<double>> distances(N, vector<double>(N));
    vector<vector<double>> pheromones(N, vector<double>(N));

    // Генерация координат городов и расстояний между ними
    for (int i = 0; i < N; ++i)
    {
        cities[i] = { rand() % 100, rand() % 100 };
        for (int j = 0; j < N; ++j)
        {
            distances[i][j] = distance(cities[i], cities[j]);
        }
    }

    initialize_pheromones(pheromones, N);

    double initial_pheromone;
    do
    {
        cout << "Введите начальное значение феромонов ([0;1]): ";
        cin >> initial_pheromone;
    } while (initial_pheromone < 0 || initial_pheromone > 1);


    double ALPHA, BETA;
    do
    {
        cout << "Введите значение ALPHA (влияние феромонов): ";
        cin >> ALPHA;
        cout << "Введите значение BETA (влияние расстояния): ";
        cin >> BETA;
    } while (ALPHA < 0 || BETA < 0);


    int iterations;
    do
    {
        cout << "Введите количество итераций: ";
        cin >> iterations;
    } while (iterations < 0);
    cout << '\n';

    vector<int> best_route;
    double best_distance = numeric_limits<double>::max();

    for (int iter = 0; iter < iterations; ++iter)
    {
        vector<int> route;
        vector<bool> visited(N, false);
        int current_city = rand() % N;
        route.push_back(current_city);
        visited[current_city] = true;

        for (int step = 1; step < N; ++step) 
        {
            // Сумма вероятности
            double sum_probabilities = 0.0;
            vector<double> probabilities(N, 0.0);

            for (int next_city = 0; next_city < N; ++next_city) 
            {
                if (!visited[next_city]) 
                {
                    // Формула 
                    // Вероятность перехода муравья из одной вершины в другую
                    probabilities[next_city] = pow(pheromones[current_city][next_city], ALPHA) * pow(1.0 / distances[current_city][next_city], BETA);
                    sum_probabilities += probabilities[next_city];
                }
            }

            double random_value = (double)rand() / RAND_MAX * sum_probabilities;
            double cumulative_probability = 0.0;
            int next_city = -1;

            for (int city = 0; city < N; ++city) 
            {
                if (!visited[city]) 
                {
                    cumulative_probability += probabilities[city];
                    if (cumulative_probability >= random_value) 
                    {
                        next_city = city;
                        break;
                    }
                }
            }

            route.push_back(next_city);
            visited[next_city] = true;
            current_city = next_city;
        }

        double current_distance = 0.0;
        for (int i = 0; i < N - 1; ++i) 
        {
            current_distance += distances[route[i]][route[i + 1]];
        }
        current_distance += distances[route[N - 1]][route[0]];

        if (current_distance < best_distance) 
        {
            best_distance = current_distance;
            best_route = route;
        }

        // Глобальное обновление феромона
        for (int i = 0; i < N; ++i) 
        {
            for (int j = 0; j < N; ++j) 
            {
                pheromones[i][j] *= (1.0 - EVAPORATION);
            }
        }

        // Формула Q/L
        // Локальное обновление феромонов
        for (int i = 0; i < N - 1; ++i) 
        {
            pheromones[route[i]][route[i + 1]] += Q / current_distance;
            pheromones[route[i + 1]][route[i]] += Q / current_distance;
        }
        pheromones[route[N - 1]][route[0]] += Q / current_distance;
        pheromones[route[0]][route[N - 1]] += Q / current_distance;

        // Вывод информации
        cout << iter + 1 << ": лучший маршрут ";
        for (int city : best_route) 
        {
            cout << city << " ";
        }
        cout << "с расстоянием " << best_distance << endl;
    }

    return 0;
}