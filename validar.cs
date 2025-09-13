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
        
        if (cantidad <= stock[posicion])
        {
            Console.WriteLine($"Puesdes hacer la compra ");
            stock[posicion] -= cantidad;
            db.total(serchProduct,cantidad, precio[posicion]);
            return true;
        }
        else
        {
            Console.WriteLine($"\tError la cantidad supera el STOCK ");
            return false;
        }
        
    }
    
    // descuetos 
    public static void validarDescuento()
    {   
        double total = 0;
        double cantidadValidar = db.allTotal;
        var historial = db.historial;
        double descuento = (cantidadValidar >= 20000) ? 20 :
            (cantidadValidar >= 10000) ? 10 : 0;
        // Console.Write($"\n\t cantidad de descuento es {descuento:F2}");
        Console.WriteLine("  |================================================================|");
        Console.WriteLine("\t\t       FACTURA STORE ANA \n");
        Console.WriteLine("\tPRODUCTO\tCANTIDAD\tVALOR U\t\tTOTAL\n");
        foreach (var i in historial)
        {
            //Console.WriteLine($"\t{producto[i],-10}\t{precio[i],12}\t{stock[i],13}");
            Console.Write($"{i:F2}\n");
        }
        total= cantidadValidar * (1- (descuento/100));
        Console.WriteLine($"\n\n");
        Console.WriteLine((descuento != 0) ? $"Descuento: {descuento}%".PadLeft(58) : "");
        Console.WriteLine($"Subtotal: {cantidadValidar:F2}".PadLeft(61));
        Console.WriteLine($"total: {total:F2}\n".PadLeft(62));
        Console.WriteLine($"\t\t**GRACIAS POR SU COMPRA TIENDASD DE ANA **");
        Console.WriteLine("  |================================================================|");
    }
}