using static System.Runtime.InteropServices.JavaScript.JSType;
Dictionary<int, Productos> productos = new Dictionary<int, Productos>();
int codigo;
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