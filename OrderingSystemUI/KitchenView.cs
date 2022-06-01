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

        public KitchenView()
        {
            InitializeComponent();
            orderedItemService = new OrderedItemService();
        }

        public void ReadListOfFoodOrders()
        {
            List<OrderedItem> foodOrderList = orderedItemService.GetFoodOrders();

            listViewKitchen.Items.Clear();
            listViewKitchen.FullRowSelect = true;

            int tableNo = 0; //this will be changed later

            foreach (OrderedItem foodOrder in foodOrderList)
            {
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
    }
}
