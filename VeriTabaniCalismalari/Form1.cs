using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabaniCalismalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
           
            dgwProducts.DataSource =_productDal.GetAll();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = textBox_Name.Text,
                UnitPrice = Convert.ToDecimal(textBox_UnitPrice.Text),
                StockAmoun = Convert.ToInt32(textBox_StockAmount.Text)


            });
            MessageBox.Show("Product added!");
        }
        
    }
}
