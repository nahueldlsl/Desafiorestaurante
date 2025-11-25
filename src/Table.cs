using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        
        private List<Dish> order = new List<Dish>();
        public int Number { get; private set; }
        public bool IsOccupied { get; private set; }
        public List<Dish> Order { get { return order; } }

        public Table(int number)
        {
            Number = number;
            IsOccupied = false;
        }
    public void Ocupy()
    {
        IsOccupied = true;
    }

    public void Free()
    {
        IsOccupied = false;
        order.Clear();
    }


    public void AddToOrder(Dish dish)
    {
        order.Add(dish);
    }

    public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
}