#include <iostream>
#include <Windows.h>
#include <vector>
#include <string>

using namespace std;

struct Item {
    string name;
    int weight;
    int price;
};

int result(int capacity, const vector<Item>& items, vector<Item>& selectedItems) {
    int countColumn = items.size();
    vector<vector<int>> DP(countColumn + 1, vector<int>(capacity + 1, 0));

    for (int i = 1; i <= countColumn; ++i) {
        for (int j = 0; j <= capacity; ++j) {
            if (items[i - 1].weight <= j) {
                DP[i][j] = max(DP[i - 1][j], DP[i - 1][j - items[i - 1].weight] + items[i - 1].price);
            }
            else {
                DP[i][j] = DP[i - 1][j];
            }
        }
    }

    int w = capacity;
    for (int i = countColumn; i > 0 && w > 0; --i) {
        if (DP[i][w] != DP[i - 1][w]) {
            selectedItems.push_back(items[i - 1]);
            w -= items[i - 1].weight;
        }
    }

    return DP[countColumn][capacity];
}

int main() 
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    int maxSize;
    cout << "Введите максимальную вместимость рюкзака: ";
    cin >> maxSize;

    int itemCount;
    cout << "Введите количество товаров: ";
    cin >> itemCount;
    cout << '\n';

    vector<Item> items(itemCount);
    for (int i = 0; i < itemCount; i++) {
        cout << "Введите информацию о товаре " << i + 1 << ":\n";
        cout << "Название: ";
        cin >> items[i].name;
        cout << "Вес: ";
        cin >> items[i].weight;
        cout << "Цена: ";
        cin >> items[i].price;
    }
    cout << '\n';

    vector<Item> selectedItems;
    int maxValue = result(maxSize, items, selectedItems);

    cout << "Максимальная стоимость в рюкзаке без повторений: " << maxValue << '\n';
    cout << "Предметы в рюкзаке:\n";
    for (const auto& item : selectedItems) {
        cout << "Предмет: " << item.name << ", вес: " << item.weight << ", цена: " << item.price << '\n';
    }

    cout << "\nО-большое равно: O(n^2)\n";

    return 0;
}
