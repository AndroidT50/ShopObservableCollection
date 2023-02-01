using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Shop
    {
        public readonly ObservableCollection<Item> Items = new ObservableCollection<Item>();

        public void Add()
        {
            Items.Add(new Item(Items.Count, "Товар от " + DateTime.Now));
        }

        public bool Remove(int id)
        {
            var item = Items.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                Items.Remove(item);
                return true;
            }
            return false;
        }

        public Shop(NotifyCollectionChangedEventHandler onItemChanged)
        {
            Items.CollectionChanged += onItemChanged;
        }
    }
}
