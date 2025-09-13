namespace store;

public class validar
{
    public static bool validarProducto(string product)
    {
        var allproduct = db.productosDb();
        var producto = allproduct.Item1;
        for (int i = 0; i < producto.Count(); i++)
        {
            if (producto[i] == product )
            {
                return true;
            }
        }
        return false;
    }

    public static bool validarCantidad(string serchProduct , int cantidad)
    {
        var allproduct = db.productosDb();  // llamo las listas 
        var stock = allproduct.Item3;
        var precio = allproduct.Item2;
        var producto = allproduct.Item1;
        int posicion = producto.IndexOf(serchProduct);
        Console.WriteLine($"El indice es {posicion}");
        if (cantidad <= stock[posicion])
        {
            Console.WriteLine($"Puesdes hacer la compra ");
            stock[posicion] -= cantidad;
            db.total(cantidad, precio[posicion]);
            return true;
        }

        return false;

    }
}