
namespace store;

public static class productos
{
    public static void allProduct()
    {
        int cantidadProducto;
        bool status;

        while (true)
        {
            Console.WriteLine("\n\t\tLa tienda de Ana\n\n ");
            Console.WriteLine("\tPRODUCTO\t\tPRECIO\t\tCANTIDAD\n");
            db.seeProduct();
         
            Console.Write($"\n\t Que producto quieres comprar ? ");
            string nuevoProducto = Console.ReadLine().ToLower();
            status = validar.validarProducto(nuevoProducto);
            if (status)
            {
                Console.Write("\t Que cantidad de producto quiere ? ");
                cantidadProducto = int.Parse(Console.ReadLine());
                validar.validarCantidad(nuevoProducto, cantidadProducto);
                
            }
            Console.Write($"\n\t Que seguir comprando  ? si/no\t");
            string seguir = Console.ReadLine().ToLower();

            if (seguir == "no")
            {
                // facturar 
                validar.validarDescuento();
                break;
            }
        }
            
            
        }

    }
