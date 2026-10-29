public class ProductoRepository : IProductoRepository
{
    private List<Producto> productos = new List<Producto>();

    public ProductoRepository()
    {
        productos.Add(new Producto { Id = 1, Nombre = "Laptop", Precio = 850000, Categoria = "Tecnologia", Activo = true });
        productos.Add(new Producto { Id = 2, Nombre = "Mouse", Precio = 15000, Categoria = "Tecnologia", Activo = true });
        productos.Add(new Producto { Id = 3, Nombre = "Silla", Precio = 120000, Categoria = "Muebles", Activo = true });
        productos.Add(new Producto { Id = 4, Nombre = "Escritorio", Precio = 200000, Categoria = "Muebles", Activo = false });
    }

    public void Agregar(Producto producto)
    {
        productos.Add(producto);
    }

    public List<Producto> ObtenerTodos()
    {
        return productos.ToList();
    }

    public Producto ObtenerPorId(int id)
    {
        return productos.FirstOrDefault(p => p.Id == id);
    }

    public List<Producto> BuscarPorCategoria(string categoria)
    {
        return productos.Where(p => p.Categoria == categoria).ToList();
    }
}
