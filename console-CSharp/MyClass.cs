namespace MyFirstClass;

public class MyClass
{
    // BODY
    
    // Constantes
    const double pi = 3.14;
    const double iva = 0.15;

    // Propiedades
    // son variables que pertenecen a una clase
    public int Number;
    public int Number2 = 3; // Se pueden iniciar
    public string Name { get; set; } // Dar nivel de accesibilidad get: Podemos obtener; set: Podemos setear; depende el nivel de acceso
    public int old { get; private set; }
    public readonly string dni; // Solo lectura a diferencia de const no necesita declarar su valor al momento de compilacion.

    // Metodos
    public string Metodo(int old)
    {
        return "you're " + old + " years old";
    }
    // Eventos
    // Indizadores
    // Operadores
    // Constructores
    // Desctructores
    // Tipos

}