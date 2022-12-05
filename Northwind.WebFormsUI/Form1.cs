using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DepedencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
            LoadCategoriesOfAddProduct();
            LoadCategoriesOfUpdateProduct();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll(); 
            cbxCategory.DisplayMember= "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        private void LoadCategoriesOfAddProduct() 
        {
            cbxAddCategoryId.DataSource = _categoryService.GetAll();
            cbxAddCategoryId.DisplayMember = "CategoryName";
            cbxAddCategoryId.ValueMember = "CategoryId";
        }

        private void LoadCategoriesOfUpdateProduct()
        {
            cbxUpdateCategoryId.DataSource = _categoryService.GetAll();
            cbxUpdateCategoryId.DisplayMember = "CategoryName";
            cbxUpdateCategoryId.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception)
            {

            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxAddCategoryId.SelectedValue),
                    ProductName = tbxAddProductName.Text,
                    UnitPrice = Convert.ToDecimal(tbxAddUnitPrice.Text),
                    QuantityPerUnit = tbxAddQuantityPerUnit.Text,
                    UnitsInStock = Convert.ToInt16(tbxAddUnitsInStock.Text)
                });
                MessageBox.Show("Product Added !");
                LoadProducts();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxUpdateProductName.Text,
                CategoryId = Convert.ToInt32(cbxUpdateCategoryId.SelectedValue),
                UnitsInStock = Convert.ToInt16(tbxUpdateUnitsInStock.Text),
                UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
                QuantityPerUnit = tbxUpdateQuantityPerUnit.Text
            });
            MessageBox.Show("Product Updated !");
            LoadProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxUpdateProductName.Text = row.Cells[2].Value.ToString();
            cbxUpdateCategoryId.SelectedValue = row.Cells[1].Value;
            tbxUpdateUnitPrice.Text = row.Cells[3].Value.ToString();
            tbxUpdateQuantityPerUnit.Text = row.Cells[4].Value.ToString();
            tbxUpdateUnitsInStock.Text = row.Cells[5].Value.ToString();

            tbxDeleteProductName.Text = row.Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Product Deleted !");
                    LoadProducts();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }

        }
    }
}
