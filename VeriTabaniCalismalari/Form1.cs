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
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = textBox_Name.Text,
                UnitPrice=Convert.ToDecimal(textBox_UnitPrice.Text),
                StockAmoun=Convert.ToInt32(textBox_StockAmount.Text)

            }) ;
            LoadProducts();
            MessageBox.Show("Product added!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            textBox_UpdateName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            textBox_UpdateUnitPrice.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            textBox_UpdateStockAmoun.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            Product product = new Product {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = textBox_UpdateName.Text,
                UnitPrice=Convert.ToDecimal(textBox_UpdateUnitPrice.Text),
                StockAmoun=Convert.ToInt32(textBox_UpdateStockAmoun.Text)
                
        };
            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Updated!");
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            MessageBox.Show("Deleted!");
        }
    }
}
