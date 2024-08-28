using System.Collections;

namespace Ucu.Poo.Restaurant;


public class Waiter
{
    public string Name { get; set; }

    private ArrayList assignedTables = new ArrayList();
    public Waiter(string name)
    {
        Name = name;
    }
    public void AssignTable(Table mesa)
    {
        assignedTables.Add(mesa);
    }

    public void TakeOrder(Table mesa, Dish plato)
    {
        mesa.AddToOrder(plato);
    }

}