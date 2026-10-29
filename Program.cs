IProductoRepository repo = new ProductoRepository();

// mostrar todos
Console.WriteLine("Lista de productos:");
var lista = repo.ObtenerTodos();
foreach (var p in lista)
{
    Console.WriteLine(p.Id + " - " + p.Nombre + " - " + p.Precio + " - " + p.Categoria + " - " + p.Activo);
}

// buscar por id
Console.WriteLine("");
Console.WriteLine("Buscar producto con id 2:");
var producto = repo.ObtenerPorId(2);
if (producto != null)
{
    Console.WriteLine(producto.Nombre + " - " + producto.Precio);
}
else
{
    Console.WriteLine("No se encontro el producto");
}

// filtrar por categoria
Console.WriteLine("");
Console.WriteLine("Productos de la categoria Muebles:");
var muebles = repo.BuscarPorCategoria("Muebles");
foreach (var p in muebles)
{
    Console.WriteLine(p.Id + " - " + p.Nombre + " - " + p.Precio);
}

// agregar uno nuevo
Console.WriteLine("");
Console.WriteLine("Agregando producto nuevo...");
Producto nuevo = new Producto();
nuevo.Id = 5;
nuevo.Nombre = "Teclado";
nuevo.Precio = 30000;
nuevo.Categoria = "Tecnologia";
nuevo.Activo = true;
repo.Agregar(nuevo);

Console.WriteLine("");
Console.WriteLine("Lista actualizada:");
var listaNueva = repo.ObtenerTodos();
foreach (var p in listaNueva)
{
    Console.WriteLine(p.Id + " - " + p.Nombre + " - " + p.Precio + " - " + p.Categoria + " - " + p.Activo);
}
