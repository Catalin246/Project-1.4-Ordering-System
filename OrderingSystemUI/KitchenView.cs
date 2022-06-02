using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderingSystemModel;
using OrderingSystemLogic;

namespace OrderingSystemUI
{
    public partial class KitchenView : Form
    {
        OrderedItemService orderedItemService;
        OrderService orderService;

        public KitchenView()
        {
            InitializeComponent();
            orderedItemService = new OrderedItemService();
            orderService = new OrderService();
            lblTime.Text = DateTime.Now.ToString("HH:mm");
        }

        public void ReadListOfFoodOrders()
        {
            List<OrderedItem> foodOrderList = orderedItemService.GetFoodOrders();

            listViewKitchen.Items.Clear();
            listViewKitchen.FullRowSelect = true;            

            foreach (OrderedItem foodOrder in foodOrderList)
            {
                //Order order = new Order()

                //ListViewItem listViewKitchenItem = new ListViewItem(tableNo.ToString());
                //listViewKitchenItem.SubItems.Add()
            }
        }

        public string GetCalculatedTime(int OrderId)
        {
            Order order = new Order(1); //change this
            DateTime a = new DateTime();
            DateTime b = new DateTime();
            a = order.OrderTime;
            b = DateTime.Now;
            return $"(b.Subtract(a).TotalMinutes) minutes ago";
        }

        //public int GetTableNoFromOrderedItem()
        //{

        //}
    }
}
