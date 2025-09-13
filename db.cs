using System.Collections.Specialized;

namespace store;

public class db
{
    public static List<string> productos = new List<string>
        { "quipitos", "papitas", "barrilete", "chicles", "alphajores" };

    public static List<double> precios = new List<double> { 3500, 3000, 600, 800, 500 };
    public static List<int> stock = new List<int> { 10, 20, 12, 25, 9 };
    public static List<string> historial = new List<string> { };
    public static double allTotal = 0.0;

    public static (List<string>, List<double>, List<int>) productosDb()
    {
        return (productos, precios, stock);
    }

    public static void seeProduct()
    {
        var allproducts = productosDb();
        var producto = allproducts.Item1;
        var precio = allproducts.Item2;
        var stock = allproducts.Item3;

        for (int i = 0; i < producto.Count(); i++)
        {
            Console.WriteLine($"\t{producto[i],-10}\t{precio[i],12}\t{stock[i],13}");
        }
    }

    public static void total(string prducto, int cantidad, double precio)
    {
        double sum = 0;
        sum = cantidad * precio;
        allTotal += sum;
        
        historial.Add($"\t{prducto,-10}\t{cantidad,4}\t{precio,12}\t{sum,13}");
        
    }


    

}