using System;
using System.Collections.Generic;
using System.Linq;

public class Set
{
    private HashSet<string> _words;

    public Set(IEnumerable<string> words)
    {
        _words = new HashSet<string>(words);
    }

    // Вложенный объект Production
    public class Production
    {
        public Guid Id { get; set; }
        public string OrganizationName { get; set; }

        public Production(Guid id, string organizationName)
        {
            Id = id;
            OrganizationName = organizationName;
        }
    }

    // Вложенный класс Developer    
    public class Developer
    {
        public string FullName { get; set; }
        public Guid Id { get; set; }
        public string Department { get; set; }

        public Developer(string fullName, Guid id, string department)
        {
            FullName = fullName;
            Id = id;
            Department = department;
        }

    }

    // Перегрузка операции удаления элемента из множества
    public static Set operator -(Set set, string item)
    {
        var result = new Set(set._words);
        result._words.Remove(item);
        return result;
    }

    // Перегрузка операции пересечения множеств
    public static Set operator *(Set set1, Set set2)
    {
        var result = new Set(set1._words.Intersect(set2._words));
        return result;
    }

    // Перегрузка операции сравнения множеств
    public static bool operator <(Set set1, Set set2)
    {
        return set1._words.Count < set2._words.Count;
    }

    public static bool operator >(Set set1, Set set2)
    {
        return set1._words.Count > set2._words.Count;
    }

    // Перегрузка операции проверки на подмножество
    public static bool operator <=(Set set1, Set set2)
    {
        return set1._words.IsSubsetOf(set2._words);
    }

    public static bool operator >=(Set set1, Set set2)
    {
        return set1._words.IsSupersetOf(set2._words);
    }

    // Объединение наборов двух последовательностей
    public static Set operator &(Set set1, Set set2)
    {
        var result = new Set(set1._words.Union(set2._words));
        return result;
    }

    public IEnumerable<string> GetElements()
    {
        return _words;
    }
}

// Статический класс StatisticOperation
public static class StatisticOperation
{
    // Метод для суммы элементов (длина всех строк)
    public static int Sum(Set set)
    {
        return set.GetElements().Sum(word => word.Length);
    }

    // Метод для разницы между максимальным и минимальным элементом ( длина строк)
    public static int Difference(Set set)
    {
        var lengths = set.GetElements().Select(word => word.Length);
        return lengths.Max() - lengths.Min();
    }

    // Метод для подсчета количества элементов
    public static int Count(Set set)
    {
        return set.GetElements().Count();
    }

    // Методы расширения для типа string
    public static string AddPeriod(this string str)
    {
        return str + ".";
    }

    // Методы расширения для типа Set
    public static Set RemoveNulls(this Set set)
    {
        var nonNullWords = set.GetElements().Where(word => word != null);
        return new Set(nonNullWords);
    }
}