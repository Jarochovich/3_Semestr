using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

public static class Reflector
{
    public static void GetAssemblyName(string className, string outputPath)
    {
        Type type = Type.GetType(className);
        string assemblyName = type?.Assembly.FullName ?? "Class not found";
        AppendToFile(outputPath, $"Имя сборки: {assemblyName}");
    }

    public static void HasPublicConstructors(string className, string outputPath)
    {
        Type type = Type.GetType(className);
        bool hasPublicConstructors = type?.GetConstructors().Any(c => c.IsPublic) ?? false;
        AppendToFile(outputPath, $"Имеет публичные конструкторы: {hasPublicConstructors}");
    }

    public static void GetPublicMethods(string className, string outputPath)
    {
        Type type = Type.GetType(className);
        var methods = type?.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                          .Select(m => m.Name) ?? Enumerable.Empty<string>();
        AppendToFile(outputPath, "Публичные методы: " + string.Join(", ", methods));
    }

    public static void GetFieldsAndProperties(string className, string outputPath)
    {
        Type type = Type.GetType(className);
        var fields = type?.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                         .Select(f => f.Name) ?? Enumerable.Empty<string>();
        var properties = type?.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                             .Select(p => p.Name) ?? Enumerable.Empty<string>();
        AppendToFile(outputPath, "Поля и свойства: " + string.Join(", ", fields.Concat(properties)));
    }

    public static void GetImplementedInterfaces(string className, string outputPath)
    {
        Type type = Type.GetType(className);
        var interfaces = type?.GetInterfaces().Select(i => i.Name) ?? Enumerable.Empty<string>();
        AppendToFile(outputPath, "Реализованные интерфейсы: " + string.Join(", ", interfaces));
    }

    public static void GetMethodsWithParameterType(string className, Type parameterType, string outputPath)
    {
        Type type = Type.GetType(className);
        var methods = type?.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                          .Where(m => m.GetParameters().Any(p => p.ParameterType == parameterType))
                          .Select(m => m.Name) ?? Enumerable.Empty<string>();
        AppendToFile(outputPath, $"Методы с типом параметра {parameterType.Name}: " + string.Join(", ", methods));
    }

    public static object InvokeMethod(object obj, string methodName, object[] parameters)
    {
        Type type = obj.GetType();
        MethodInfo method = type.GetMethod(methodName);
        return method?.Invoke(obj, parameters);
    }

    public static object InvokeMethodFromFile(string className, string methodName, string filePath)
    {
        Type type = Type.GetType(className);
        MethodInfo method = type?.GetMethod(methodName);
        if (method == null) return null;

        var parameters = File.ReadAllLines(filePath)
                             .Select(line => Convert.ChangeType(line, method.GetParameters()[0].ParameterType))
                             .ToArray();
        object instance = Activator.CreateInstance(type);
        return method.Invoke(instance, parameters);
    }

    public static object InvokeMethodWithGeneratedParameters(string className, string methodName)
    {
        Type type = Type.GetType(className);
        MethodInfo method = type?.GetMethod(methodName);
        if (method == null) return null;

        var parameters = method.GetParameters()
                               .Select(p => GenerateValue(p.ParameterType))
                               .ToArray();
        object instance = Activator.CreateInstance(type);
        return method.Invoke(instance, parameters);
    }

    public static T Create<T>(params object[] args)
    {
        Type type = typeof(T);
        return (T)Activator.CreateInstance(type, args);
    }

    private static object GenerateValue(Type type)
    {
        if (type == typeof(int)) return 1;
        if (type == typeof(string)) return "GeneratedString";
        if (type == typeof(bool)) return true;
      
        return Activator.CreateInstance(type);
    }

    public static void AppendToFile(string fileName, string content)
    {
        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            writer.WriteLine(content);
        }
    }
}




























//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace lab_11
//{
//    static class Reflector
//    {
//        // a)
//        public static string DefinitionNamespace<T>(T classNamespace)
//        {
//            Type type = classNamespace.GetType();
//            return type.Namespace;
//        }

//        // b)
//        public static bool HasPublicConstructor<T>(T className)
//        {
//            Type type = className.GetType();
//            ConstructorInfo[] constructors = type.GetConstructors();

//            if (constructors == null)  return false;

//            return true;
//        }

//        // c)
//        public static IEnumerable<string> ExstractPublicConstructor<T>(T className)
//        {
//            Type type = className.GetType();
//            ConstructorInfo[] constructors = type.GetConstructors();

//            List<string> constructorsName = new List<string>();

//            foreach (var item in constructors)
//            {
//                constructorsName.Add(item.ToString());
//            }

//            return constructorsName;
//        }

//        // d)
//        public static IEnumerable<string> GetInfoMethodAndField<T>(T className)
//        {
//            // здесь уже начал сокращать немножко код, вроде красиво
//            FieldInfo[] fields = className.GetType().GetFields();
//            MethodInfo[] methods = className.GetType().GetMethods();

//            List<string> info = new List<string>();

//            foreach (var item in fields)
//            {
//                info.Add(item.ToString());
//            }

//            foreach (var item in methods)
//            {
//                info.Add(item.ToString());
//            }

//            return info;
//        }

//        // e)
//        public static IEnumerable<string> GetInterfaceByClass<T>(T className)
//        {
//            Type[] interfacesClass = className.GetType().GetInterfaces();

//            List<string> interfaces = new List<string>();

//            foreach (var item in interfacesClass)
//            {
//                interfaces.Add(item.ToString());
//            }

//            return interfaces;
//        }

//        // f)
//        public static void GetInfoMethods<T>(T className)
//        {
//            Type type = className.GetType();

//            foreach (MemberInfo member in type.GetMethods())
//            {
//                Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
//            }
//        }

//        // g)




//}
