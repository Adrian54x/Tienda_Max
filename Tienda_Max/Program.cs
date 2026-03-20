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
            Console.WriteLine("Precione doble e nter para salir");
            do
            {
                val2 = true;
                Console.Write("Codigo del producto:");
                int codigo = int.Parse(Console.ReadLine());
                Productos p = new Productos();
                Console.Write("Nombre del producto:");
                Console.Write("Precio del producto:");


            } while (val2);
            break;
        case 2:
            case 3:
            case 4:
        case 5:

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
    public string nombre;
    public double precio;
    public void MostrarProductos()
    {
        Console.WriteLine($"\nNombre: {nombre} \nPrecio:Q{precio:F2} \nCodigo:{Codigo}");
    }
}