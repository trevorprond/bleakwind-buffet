
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.Specialized;

namespace BleakwindBuffet.Data
{
    public class Order : INotifyPropertyChanged, INotifyCollectionChanged
    {
        /// <summary>
        /// Constrcutor
        /// </summary>
        public Order()
        {
            orderNumber += 1;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        private static uint orderNumber = 0;
        /// <summary>
        /// Order number
        /// </summary>
        public uint OrderNumber
        { get { return orderNumber; } private set { orderNumber = value; } }

        /// <summary>
        /// list of items for the order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// list of items for the order
        /// </summary>
        public ICollection<IOrderItem> Items { get { return items.ToArray(); } }

        /// <summary>
        /// Cost of the order
        /// </summary>
        public double Subtotal
        {
            get
            {
                double total = 0;
                foreach (var item in items)
                {
                    total += item.Price;
                }
                return total;
            }
        }

        /// <summary>
        /// sales tax of the order
        /// </summary>
        public double SalesTax
        {
            get
            {
                return Subtotal * .12;
            }
        }
        /// <summary>
        /// Cost of the order including the sales tax
        /// </summary>
        public double Total
        {
            get
            {
                return Subtotal * 1.12;
            }
        }

        /// <summary>
        /// Adds an item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            OnItemPropertyChanged();
        }

        /// <summary>
        /// Removes an item from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            if (items.Contains(item))
            {
                var index = items.IndexOf(item);

                items.Remove(item);
                CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
                OnItemPropertyChanged();
            }
        }

        /// <summary>
        /// Allows the user to go back and change their order
        /// </summary>
        /// <param name="item"></param>
        public void ChangeOrder(IOrderItem item)
        {
            OnItemPropertyChanged();

        }

        /// <summary>
        /// Clears the order after the order is placed
        /// </summary>
        public void Clear()
        {
            ((ICollection<IOrderItem>)items).Clear();
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset, items));
            OnItemPropertyChanged();
        }

        /// <summary>
        /// Updates the items and subtotal
        /// </summary>
        public void OnItemPropertyChanged()
        {
                                   
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }
    }
}
