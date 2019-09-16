using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormsApp
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string order = comboBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox.Text);
            int amount = 0;

            if (comboBox.Text == "Black")
            {
                amount = 120;
            }
            else if (comboBox.Text == "Cold")
            {
                amount = 100;
            }
            else if (comboBox.Text == "Hot")
            {
                amount = 90;
            }
            else if (comboBox.Text == "Regular")
            {
                amount = 80;
            }

            int totalPrice = amount * quantity;

            const int size = 1;
            string[,] array = new string[10,6];
            


            for (int i = 0; i < size; i++)
            {
                array[i, 0] = Convert.ToString(nameTextBox.Text);
                array[i, 1] = Convert.ToString(contactTextBox.Text);
                array[i, 2] = Convert.ToString(addressTextBox.Text);
                array[i, 3] = Convert.ToString(comboBox.Text);
                array[i, 4] = Convert.ToString(quantityTextBox.Text);
                array[i, 5] = Convert.ToString(totalPrice);


               richTextBox.Text += "\n Customer Name: " + array[i, 0] + "\n" +
              "Contact Number: " + array[i, 1] + "\n" +
              "Address: " + array[i, 2] + "\n " +
              "Order: " + array[i, 3] +"\n"+"Quantity: "+ array[i, 4]+ "\n" + "Total Price: " + array[i, 5]+"\n";
            }
            }
    }
}
