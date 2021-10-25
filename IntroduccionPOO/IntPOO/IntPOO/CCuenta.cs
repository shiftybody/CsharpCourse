using System;

class CCuenta
{
    private string nombre;
    private string cuenta;
    private double saldo;
    private double tipoDeInteres;
    
    
    // en c# utilizamos value como parametro implicito con el mismo tipo que el atributo.
    // si la propiedad/atributo es de solo lectura o solo escritura se pueden escribir por separado;
    
    // una interfaz: son los medios de comunicacion con otro objeto y se refiere al conjunto de metodos
    // con los cuales se comunica
    public void asgniarNombre(string nom)
    {
        if (nom.Length == 0)
        {
            Console.WriteLine("Error: cadena vacia");
        }

        nombre = nom;
    }

    public string obtenerNombre()
    {
        return nombre;
    }

    public void asgniarCuenta(string cue)
    {
        if (cue.Length == 0)
        {
            Console.WriteLine("Error: cuenta no valida");
            return;
        }

        cuenta = cue;
    }

    public string obtenerCuenta()
    {
        return cuenta;
    }

    public double estado()
    {
        return saldo;
    }

    public void ingreso(double cantidad)
    {
        if (cantidad < 0)
        {
            Console.WriteLine("Error; cantidad negativa");
            return;
        }

        saldo += cantidad;
    }
    
    public void reintegro(double cantidad)
    {
        if (saldo - cantidad < 0)
        {
            Console.WriteLine("Error; no dispone de saldo");
            return;
        }

        saldo -= cantidad;
    }
    
    public void asignarTipoDeInteres(double tipo)
    {
        if (tipo < 0)
        {
            Console.WriteLine("Error; tipo no valido");
            return;
        }

        tipoDeInteres = tipo;
    }

    public double obtenerTipoDeInteres()
    {
        return tipoDeInteres;
    }
    


}