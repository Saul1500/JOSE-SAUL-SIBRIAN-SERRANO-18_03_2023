// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using Almacen.Models;


using (AlmacenContext db = new AlmacenContext())
{
    Producto producto = new Producto();

    //Console.WriteLine("Ingrese El Id del Producto: ");
    //producto.Id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese El Nombre del Producto: ");
    producto.Nombre = Console.ReadLine();

    Console.WriteLine("Ingrese la Descripcion del Producto: ");
    producto.Descripcion = Console.ReadLine();

    Console.WriteLine("Ingrese el Precio del Producto: ");
    producto.Precio = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Ingrese la Cantidad de Stock: ");
    producto.Stock = Convert.ToInt32(Console.ReadLine());

    db.Productos.Add(producto);
    db.SaveChanges();
}