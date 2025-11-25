using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        public string Name { get; set; }
        private List<Table> assignedTables = new List<Table>();

        public void AssignTable(Table table)
        {
            assignedTables.Add(table);
        }


        public void TakeOrder(Table table)
        {
            foreach (Table t in assignedTables)
            {
                
            }
        }
    }
}