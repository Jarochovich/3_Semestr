using System.Collections.Generic;
using System;

public class Program
{
    public static void Main()
    {
        string concertOutput = "ConcertOutput.txt";
        string listOutput = "ListOutput.txt";
        string createObjOutput = "CreateObjOutput.txt";
        string customerOutput = "CustomerOutput.txt";

        // Исследование класса Concert
        Reflector.GetAssemblyName("Concert", concertOutput);
        Reflector.HasPublicConstructors("Concert", concertOutput);
        Reflector.GetPublicMethods("Concert", concertOutput);
        Reflector.GetFieldsAndProperties("Concert", concertOutput);
        Reflector.GetImplementedInterfaces("Concert", concertOutput);
        Reflector.GetMethodsWithParameterType("Concert", typeof(string), concertOutput);

        // Иследование класса Customer
        Reflector.GetAssemblyName("Customer", customerOutput);
        Reflector.HasPublicConstructors("Customer", customerOutput);
        Reflector.GetPublicMethods("Customer", customerOutput);
        Reflector.GetFieldsAndProperties("Customer", customerOutput);
        Reflector.GetImplementedInterfaces("Customer", customerOutput);
        Reflector.GetMethodsWithParameterType("Customer", typeof(string), customerOutput);


        // Исследование интерфейса IList
        Reflector.GetAssemblyName("IList", listOutput);
        Reflector.HasPublicConstructors("IList", listOutput);
        Reflector.GetPublicMethods("IList", listOutput);
        Reflector.GetFieldsAndProperties("IList", listOutput);
        Reflector.GetImplementedInterfaces("IList", listOutput);
        Reflector.GetMethodsWithParameterType("IList", typeof(string), listOutput);

        // Создание объектов с помощью метода Create
        var concert = Reflector.Create<Concert>("John Doe", 30, "2024-12-31", 100, "Stadium");
        var list = Reflector.Create<List<string>>();

        // Вывод созданных объектов
        Reflector.AppendToFile(createObjOutput, $"Created Concert: {concert.GetNameSinger()}");
        Reflector.AppendToFile(createObjOutput, $"Created List: {string.Join(", ", list)}");

        Console.WriteLine("Вся информация записана в файлы");
    }
}
















//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Customer customer = new Customer(Guid.NewGuid(), "Сергей", "Петров", "Иванович", "ул. Семашко, 9", "41125795", 9000);

//        Console.WriteLine("Название сборки:");
//        Console.WriteLine( Reflector.DefinitionNamespace<Customer>(customer) );

//        Console.WriteLine("\nИмеются ли открытые конструкторы?");
//        Console.WriteLine( Reflector.HasPublicConstructor<Customer>(customer) );

//        var listConstructors =  Reflector.ExstractPublicConstructor<Customer>(customer);

//        Console.WriteLine("\nКонструкторы класса Customer:");
//        foreach (var constructor in listConstructors)
//        {
//            Console.WriteLine(constructor);
//        }


//        var listInfoMethodAndField = Reflector.GetInfoMethodAndField<Customer>(customer);

//        Console.WriteLine("\nМетоды и поля класса Customer:");
//        foreach (var item in listInfoMethodAndField)
//        {
//            Console.WriteLine(item);
//        }

//        var listInterfaces = Reflector.GetInterfaceByClass<Customer>(customer);

//        Console.WriteLine("\nРеализованные интерфейсы:");
//        foreach (var item in listInterfaces)
//        {
//            Console.WriteLine(item);
//        }

//        Console.WriteLine("\nМетоды класса Customer:");
//        Reflector.GetInfoMethods<Customer>(customer);

//    }
//}

