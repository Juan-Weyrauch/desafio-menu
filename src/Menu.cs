using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>
public class Menu
{
    private string nombre { get; set };
    private int precio { get; set };
    private bool esVegetariano;
    private ArrayList dishes = new ArrayList();

    public Menu(string unNombre, int unPrecio, bool unEsVegetariano)
    {
        this.nombre = unNombre;
        this.precio = unPrecio;
        this.esVegetariano = unEsVegetariano;
    }

    public void AddDish(Dish dish)
    {
        dishes.Add(dish);
    }


    public void RemoveDish(Dish dish)
    {
        dishes.Clear(dish);
    }

    public Dish GetDishByName(string nombre)
    {
        foreach (var dish in dishes)
        {
            if (dish.Nombre == nombre)
            {
                return dish;
            }
        }

        Console.WriteLine("Dish not found");
        return null;
    }

}
