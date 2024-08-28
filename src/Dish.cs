namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish
{
    public string Name { get; set; }
    public double Price { get; set; }
    public bool IsVegetarian { get; set; }

    public Dish(string nombre, double precio, bool EsVegetariano)
    {
        this.Name = nombre;
        this.Price = precio;
        this.IsVegetarian = EsVegetariano;
    }
}