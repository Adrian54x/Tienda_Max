using static System.Runtime.InteropServices.JavaScript.JSType;
Dictionary<int, Productos> productos = new Dictionary<int, Productos>();
bool val1, val2;
do 
{
    val1 = true;
    Console.Clear();
    Console.WriteLine("1. Agregar producto");
    Console.WriteLine("2. Modificar producto");
    Console.WriteLine("3. Eliminar producto");
    Console.WriteLine("4. Buscar producto");
    Console.WriteLine("5. Mostrar todos los productos");
    Console.WriteLine("6. Salir");
    Console.Write("Elija una opcion");
    int opcion = int.Parse(Console.ReadLine());
    switch(opcion)
    {
        case 1:
            Console.WriteLine("Precione enter para salir");
            do
            {
                val2 = true;
                Productos p = new Productos();      
                Console.Write("\nNombre del producto:");
                p.Nombre = Console.ReadLine();
                if (p.Nombre == "")
                {
                    Console.WriteLine("Saliendo");
                    val2 = false;
                }
                else
                {
                    Console.Write("Codigo del producto:");
                    int codigo = int.Parse(Console.ReadLine());
                    p.Codigo = codigo;
                    Console.Write("Precio del producto:");
                    p.Precio = double.Parse(Console.ReadLine());
                    productos.Add(codigo, p);
                }

            } while (val2);
            break;
        case 2:
            case 3:
            case 4:
        case 5:
            foreach(var p  in productos)
            {
                p.Value.MostrarProductos();
            }
            break;
        case 6:
            Console.WriteLine("Saliendo...");
            val1 = false;
            break;
        default:
            Console.WriteLine("Opcion no valida!");
            Thread.Sleep(500);
            break;
    }
} while (val1);
class Productos
{
    public int Codigo;
    public string Nombre;
    public double Precio;
    public void MostrarProductos()
    {
        Console.WriteLine($"\nNombre: {Nombre} \nPrecio:Q{Precio:F2} \nCodigo:{Codigo}");
    }
}