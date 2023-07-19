using System.Collections;
using System.Text;
using console_CSharp;
using MyFirstClass;

namespace Program;

public class Program
{
    static void Main(string[] args)
    {
        MyClass myClass = new MyClass();

        Console.WriteLine(myClass.Metodo(5));

        Point_Class pointClass = new Point_Class();
        pointClass.x = 10;
        pointClass.y = 8;

        Point_Struct pointStruct = new Point_Struct();
        pointStruct.x = 20;
        pointStruct.y = 7;

        plusCoorditanesClass(pointClass);
        plusCoorditanesStruct(pointStruct);

        ArrayList arr = new ArrayList();
        arr.Add("4");
        arr.Add("HOLA");
        arr.Add(3);

        Console.WriteLine(arr);

        // La diferencia entre una clase y una structura es que las structuras se pasan por valor y las clases por referencia.
        Console.WriteLine($"Suma de coordenadas clase: X={pointClass.x} Y={pointClass.y}");
        Console.WriteLine($"Suma de coordenadas struct: X={pointStruct.x} Y={pointStruct.y}");

        /*
             * Normal Class
             */

        // Crear una instancia de Normal_Class
        Normal_Class normalClassInstance = new Normal_Class();

        // Establecer valores para age y name (opcional)
        normalClassInstance.age = 30;
        normalClassInstance.name = "John";

        // Llamar al método showMe() e imprimir el resultado
        string result = normalClassInstance.showMe();
        Console.WriteLine(result);

        /*
         * Static Class
         */
        Static_Class.age = 5;
        Static_Class.name = "Roberto";
        string result2 = Static_Class.showMe();
        Console.WriteLine(result2);
    }

    public static void plusCoorditanesClass(Point_Class point)
    {
        point.x += 10;
        point.y += 10;
    }

    public static void plusCoorditanesStruct(Point_Struct point)
    {
        point.x += 10;
        point.y += 10;
    }
}