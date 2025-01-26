#include <iostream>
#include <Windows.h>
#include <queue>
#include <unordered_map>
#include <vector>
#include <string>
#include <iomanip>
#include <algorithm>

using namespace std;

// Структура для узла дерева Хаффмана
struct Node {
    char character;
    int frequency;
    Node* left;
    Node* right;

    // Конструктор узла с пояснением
    Node(char ch, int freq) {
        character = ch;        // Символ, который хранится в узле
        frequency = freq;      // Частота этого символа
        left = nullptr;        // Левый потомок (по умолчанию nullptr)
        right = nullptr;       // Правый потомок (по умолчанию nullptr)
    }
};

// Компаратор для приоритета очереди
struct Compare {
    bool operator()(Node* l, Node* r) {
        return l->frequency > r->frequency;
    }
};

// Рекурсивная функция для создания кодов символов
void generateCodes(Node* root, const string& str, unordered_map<char, string>& codes) {
    if (!root) return;

    if (root->left == nullptr && root->right == nullptr) {
        codes[root->character] = str;
    }

    generateCodes(root->left, str + "0", codes);
    generateCodes(root->right, str + "1", codes);
}

// Функция для построения дерева Хаффмана
Node* buildHuffmanTree(const unordered_map<char, int>& frequency) {
    priority_queue<Node*, vector<Node*>, Compare> minHeap;

    for (const auto& pair : frequency) {
        minHeap.push(new Node(pair.first, pair.second));
    }

    while (minHeap.size() > 1) {
        Node* left = minHeap.top(); minHeap.pop();
        Node* right = minHeap.top(); minHeap.pop();
        Node* combined = new Node('\0', left->frequency + right->frequency);
        combined->left = left;
        combined->right = right;
        minHeap.push(combined);
    }

    return minHeap.top();
}

// Функция для освобождения памяти
void freeHuffmanTree(Node* root) {
    if (!root) return;
    freeHuffmanTree(root->left);
    freeHuffmanTree(root->right);
    delete root;
}

// Функция для подсчета частоты символов
unordered_map<char, int> calculateFrequency(const string& text) {
    unordered_map<char, int> frequency;
    for (char ch : text) {
        frequency[ch]++;
    }
    return frequency;
}

// Функция для сортировки символов по убыванию частоты
vector<pair<char, int>> sortFrequency(const unordered_map<char, int>& frequency) {
    vector<pair<char, int>> sortedFrequency(frequency.begin(), frequency.end());

    sort(sortedFrequency.begin(), sortedFrequency.end(), [](const pair<char, int>& a, const pair<char, int>& b) {
        return a.second > b.second;
        });

    return sortedFrequency;
}

// Функция для кодирования текста
string encodeText(const string& text, const unordered_map<char, string>& codes) {
    string encoded;
    for (char ch : text) {
        encoded += codes.at(ch);
    }
    return encoded;
}

// Функция для декодирования текста
string decodeText(const string& encodedText, Node* root) {
    string decoded;
    Node* current = root;

    for (char bit : encodedText) {
        // Переход влево, если бит '0', и вправо, если бит '1'
        current = (bit == '0') ? current->left : current->right;

        // Если достигли листа (символа)
        if (current->left == nullptr && current->right == nullptr) {
            decoded += current->character;  // Добавляем символ к раскодированному тексту
            current = root;  // Возвращаемся к корню для следующего символа
        }
    }

    return decoded;
}

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    string text;
    cout << "Введите текст (например, ФИО студента): ";
    getline(cin, text);

    if (text.empty()) {
        cout << "Ошибка: Введен пустой текст.\n";
        return 1;
    }

    // Подсчет частоты символов
    unordered_map<char, int> frequency = calculateFrequency(text);
    int totalChars = text.size();

    Node* root = buildHuffmanTree(frequency);

    // Генерация кодов символов
    unordered_map<char, string> codes;
    generateCodes(root, "", codes);

    // Сортируем частоты символов по убыванию для вывода
    vector<pair<char, int>> sortedFrequency = sortFrequency(frequency);

    // Вывод таблицы частот символов
    cout << "\nТаблица встречаемости символов:\n";
    cout << setw(10) << "Символ" << setw(15) << "Частота" << setw(15) << "Процент\n";
    for (const auto& pair : sortedFrequency) {
        cout << setw(10) << pair.first
            << setw(15) << pair.second
            << setw(15) << fixed << setprecision(2) << (static_cast<double>(pair.second) / totalChars * 100) << "%\n";
    }

    // Вывод таблицы кодов символов
    cout << "\nТаблица соответствия символа и кодовой последовательности:\n";
    cout << setw(10) << "Символ" << setw(15) << "Код\n";
    for (const auto& pair : codes) {
        cout << setw(10) << pair.first << setw(15) << pair.second << "\n";
    }

    // Кодирование текста
    string encodedText = encodeText(text, codes);
    cout << "\nЗакодированная последовательность:\n" << encodedText << "\n";

    // Декодирование текста
    string decodedText = decodeText(encodedText, root);
    cout << "\nДекодированный текст:\n" << decodedText << "\n";

    // Освобождение памяти
    freeHuffmanTree(root);

    return 0;
}
