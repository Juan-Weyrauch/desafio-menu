namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish
{
    private string Name { get; set; }
    private int Price { get; set; }
    private bool IsVegetarian { get; set; }

    public Dish(string nombre, int precio, bool EsVegetariano)
    {
        this.Name = nombre;
        this.Price = precio;
        this.IsVegetarian = EsVegetariano;
    }
}