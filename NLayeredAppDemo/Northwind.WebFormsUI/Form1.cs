using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        
        IProductService _productService;
        ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();

        }

        //ComboBox'a kategoriyi getirme
        private void LoadCategories()
        {
            cbxCategoryList.DataSource = _categoryService.GetCategories();
            cbxCategoryList.DisplayMember = "CategoryName";
            cbxCategoryList.ValueMember = "CategoryId";

            cbxCategoryId.DataSource = _categoryService.GetCategories();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";

        }

        private void LoadProducts()
        {
            dataGridView1.DataSource = _productService.GetProducts();
        }
        //Texboxt girilen karakterler ile Filtreleme
        private void cbxCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                dataGridView1.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategoryList.SelectedValue));
            }
            catch
            {


            }

        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            string key = txtProductSearch.Text;
            if (string.IsNullOrEmpty(key))
            {
                LoadProducts();
            }
            else
            {
                dataGridView1.DataSource = _productService.GetProductsByProductName(txtProductSearch.Text);

            }

        }

        //Ürün Ekleme
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {

                    ProductName = txtProductName.Text,
                    CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text),
                    QuantityPerUnit = txtQuantityPerUnit.Text
                });

                MessageBox.Show("Ürün Başarıyla Kaydedildi...");
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        //Ürün güncelleme
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(txtProductId.Text), //Dikkat edilmesi gereken bir durum. Güncelleme Ve silme işlemlerinde id gerekmektedir. Bu yüzden onuda ekleriz.
                    ProductName = txtProductName.Text,
                    CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text),
                    QuantityPerUnit = txtQuantityPerUnit.Text

                });

                MessageBox.Show("Ürün başarıyla güncellendi...");
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        //CellClick Event datagridview de  her tıklamada  o hücre veya sütundaki bilgileri bana getirmeye yarıyor.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtProductName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbxCategoryId.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
            txtUnitPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtUnitsInStock.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtQuantityPerUnit.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)


                    });
                    MessageBox.Show("Ürün Başarıyla Silindi");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

        }
    }
}
