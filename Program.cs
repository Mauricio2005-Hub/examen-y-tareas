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

    public void MostrarProductos()
    {
        if (producto != null)
        {
            Console.WriteLine(producto.ToString());
            siguienteProducto.MostrarProductos();
        }
    }

    public double CalcularPrecioTotal()
    {
        if (producto == null)
        {
            return 0;
        }
        else
        {
            return producto.Precio + siguienteProducto.CalcularPrecioTotal();
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Tienda tienda = new Tienda();

        Producto producto1 = new Producto("Producto 1", 101, 10.5);
        Producto producto2 = new Producto("Producto 2", 102, 20.75);
        Producto producto3 = new Producto("Producto 3", 103, 15.0);

        tienda.AgregarProducto(producto1);
        tienda.AgregarProducto(producto2);
        tienda.AgregarProducto(producto3);

        Console.WriteLine("Información de todos los productos:");
        tienda.MostrarProductos();

        double precioTotal = tienda.CalcularPrecioTotal();
        Console.WriteLine($"Precio total de todos los productos: {precioTotal}");
    }
}