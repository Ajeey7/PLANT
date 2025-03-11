using OperationOOP.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace OperationOOP.Core.Data
{
    public class Database<T> : IDatabase<T> where T : IEntity
    {
        public List<T> Items { get; set; } = new List<T>();

        // Lägg till ett objekt
        public void AddItem(T item)
        {
            Items.Add(item);
        }

        // Hämta ett objekt baserat på ID
        public T GetItemById(int id)
        {
            return Items.FirstOrDefault(item => item.Id == id);
        }

        // Hämta alla objekt
        public List<T> GetItems()
        {
            return Items;
        }

        // Ta bort ett objekt baserat på ID
        public void RemoveItem(int id)
        {
            var itemToRemove = GetItemById(id);
            if (itemToRemove != null)
            {
                Items.Remove(itemToRemove);
            }
        }
    }
}
