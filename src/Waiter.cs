using System.Collections;

namespace Ucu.Poo.Restaurant;


public class Waiter
{
    private string Name { get; set; }

    private ArrayList assignedTables = new ArrayList();

    public void AssignTable(Table mesa)
    {
        assignedTables.Add(mesa);
    }

    public void TakeOrder(Table mesa, Dish plato)
    {
        mesa.AddToOrder(plato);
    }

}