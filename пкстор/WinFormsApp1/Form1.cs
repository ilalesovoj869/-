using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class Form1 : Form
    {
        string db = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\PCStore\Database1.mdb;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var con = new OleDbConnection(db))
                {
                    con.Open();
                    var reader = new OleDbCommand("SELECT [Name], [Price] FROM [Products]", con).ExecuteReader();
                    while (reader.Read())
                        listBoxProducts.Items.Add(new Item(reader.GetString(0), reader.GetDecimal(1)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка базы");
            }
            ShowTotal();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var item = listBoxProducts.SelectedItem as Item;
            if (item == null)
            {
                MessageBox.Show("Выберите товар");
                return;
            }

            int qty = (int)numQuantity.Value;

            for (int i = 0; i < listBoxCart.Items.Count; i++)
            {
                var c = (Item)listBoxCart.Items[i];
                if (c.Name == item.Name)
                {
                    c.Qty += qty;
                    listBoxCart.Items[i] = c;
                    ShowTotal();
                    return;
                }
            }

            listBoxCart.Items.Add(new Item(item.Name, item.Price) { Qty = qty });
            ShowTotal();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxCart.SelectedIndex >= 0)
                listBoxCart.Items.RemoveAt(listBoxCart.SelectedIndex);
            ShowTotal();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            listBoxCart.Items.Clear();
            ShowTotal();
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            if (listBoxCart.Items.Count == 0)
            {
                MessageBox.Show("Корзина пуста!");
                return;
            }

            MessageBox.Show("Заказ оформлен!\n" + lblTotal.Text);
            listBoxCart.Items.Clear();
            ShowTotal();
        }

        private void ShowTotal()
        {
            decimal total = 0;
            foreach (Item c in listBoxCart.Items)
                total += c.Price * c.Qty;
            lblTotal.Text = "Итого: " + total.ToString("N0") + " ₽";
        }
    }

    class Item
    {
        public string Name;
        public decimal Price;
        public int Qty;

        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            if (Qty == 0)
                return Name + " — " + Price.ToString("N0") + " ₽";
            return Name + " ×" + Qty + " = " + (Price * Qty).ToString("N0") + " ₽";
        }
    }
}