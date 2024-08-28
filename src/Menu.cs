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
    private string nombre { get; set; }
    private double precio { get; set; }
    private bool esVegetariano { get; set; }
    private ArrayList dishes = new ArrayList();
    
    public void AddDish(Dish dish)
    {
        dishes.Add(dish);
    }


    public void RemoveDish(Dish dish)
    {
        dishes.Remove(dish);
    }

    public Dish GetDishByName(string nombre)
    {
        foreach ( Dish plato in dishes)
        {
            if (plato.Name == nombre)
            {
                return plato;
            }
        }

        Console.WriteLine("Dish not found");
        return null;
    }

}
