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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            drinksComboBox1.SelectedItem = Drinks.Tea;
            drinksComboBox1.DataSource = Enum.GetValues(typeof(Drinks));


            string drink = drinksComboBox1.SelectedItem.ToString() ?? " ";

        }
    }
}
