using System;

public class Producto
{
    private string nombre;
    private int codigo;
    private double precio;

    public Producto(string nombre, int codigo, double precio)
    {
        this.nombre = nombre;
        this.codigo = codigo;
        this.precio = precio;
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public double Precio
    {
        get { return precio; }
        set { precio = value; }
    }

    public override string ToString()
    {
        return $"Nombre: {nombre}, Código: {codigo}, Precio: {precio}";
    }
}

public class Tienda
{
    private Producto producto;
    private Tienda siguienteProducto;

    public Tienda()
    {
        producto = null;
        siguienteProducto = null;
    }

    public voidf AgregarProducto(Producto nuevoProducto
    {
        if (producto == null)
        {
            producto = nuevoProducto;
            siguienteProducto = new Tienda();
        }
        else
        {
            siguienteProducto.AgregarProducto(nuevoProducto);
        }
    }

}
