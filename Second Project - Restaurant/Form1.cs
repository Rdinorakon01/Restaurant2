using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Project___Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Server server = new Server();
        bool res = false;
        bool send = true;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            drinksComboBox1.SelectedItem = Drinks.Tea;
            drinksComboBox1.DataSource = Enum.GetValues(typeof(Drinks));


            string drink = drinksComboBox1.SelectedItem.ToString() ?? " ";

        }

        private void receiveRequestButton1_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            int chickenQuantity = Convert.ToInt32(chickenTextBox1.Text);
            int eggQuantity = Convert.ToInt32(eggTextBox2.Text);
            Drinks drinks = (Drinks)drinksComboBox1.SelectedValue;
            server.ReceiveRequest(chickenQuantity, eggQuantity, drinks);
            try 
            {
                res = true;
                send = true;
                int quantityChicken = 0;
                if(!int.TryParse(chickenTextBox1.Text, out quantityChicken))
                {
                    MessageBox.Show("Please enter correct number of chicken count");
                }
                int quantityEgg = 0;
                if (!int.TryParse(eggTextBox2.Text, out quantityEgg))
                {
                    MessageBox.Show("Please enter correct number of egg count");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }



        }

        private void sendCustomerRequestButton2_Click(object sender, EventArgs e)
        {
            if (res && send)
            {
                resultListBox1.Items.Clear();
                send = !send;
                server.SendRequest();
            }
            else MessageBox.Show("Request wasn't called before");
        }

        private void servePreparedFoodButton3_Click(object sender, EventArgs e)
        {
            MenuItem position = MenuItem.Chicken;
            if (position == MenuItem.Egg || position == MenuItem.Chicken)
            {
                Console.WriteLine(""); return;
            }
            Console.WriteLine("");
            if (res && send == false)
            {
                resultListBox1.Items.Clear();
                send = !send;
                string result = server.Serve();
                resultListBox1.Items.Add(result);
            }
            else MessageBox.Show("Request id prepared or hasn't been ordered yet!");
        }

        private void chickenRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
                RadioButton radiobutton = (RadioButton)sender;
                string MenuItem = chickenRadioButton1.Text;
        }

        private void eggRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radiobutton = (RadioButton)sender;
            string MenuItem = eggRadioButton2.Text;
        }
    }
}
