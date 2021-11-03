using System;
using System.Collections.Generic;
using System.Text;
using Order.Entities;
using Order.Entities.Enums;

namespace Order.Entities
{
    class OrderS
    {
        public DateTime Moment { get; set; }
        public Enum Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public OrderS()
        {
        }

        public OrderS(DateTime moment, Enum orederStatus, Client client)
        {
            Moment = moment;
            Status = orederStatus;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.AppendLine("Order moment: " + DateTime.Now);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client : " + Client);
            sb.AppendLine("Order items: ");
            foreach (OrderItem orderItem in Items)
            {
                sb.AppendLine(orderItem.ToString());
            }
            sb.AppendLine("Total price: $" + Total());
            return sb.ToString();
            
        }
    }
}
