using System;

class Test
{
    public static void Main(string[] args)
    {
        // se crea/instancia un objeto de la clase cuenta referenciado en la variable cuenta01
        CCuenta cuenta01 = new CCuenta();
        cuenta01.asgniarNombre("Un nombre");
        cuenta01.asgniarCuenta("Una cuenta");
        cuenta01.asignarTipoDeInteres(2.5);
        
        cuenta01.ingreso(12000);
        cuenta01.reintegro(3000);
        
        // para acceder a un miembro(metodo-atributo) de un objeto se utiliza la sintaxis
        // nombreObjeto.nombreMetodo
        Console.WriteLine(cuenta01.obtenerNombre());
        Console.WriteLine(cuenta01.obtenerCuenta());
        Console.WriteLine(cuenta01.estado());
        Console.WriteLine(cuenta01.obtenerTipoDeInteres());
        
        // consideraciones: 
        // cualquier método de una clase tiene acceso es decir, puede incovar,
        // a todos los miembros de su clase
        // ---
        // un objeto de una clase solo puede invocar a metodos de su clase
        // es decir solo responde a los mensajes para los que ha sido programado
    }
}