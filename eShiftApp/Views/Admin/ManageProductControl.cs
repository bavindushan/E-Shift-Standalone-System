using System;
using System.Linq;
using System.Windows.Forms;
using eShiftApp.Controllers;
using eShiftApp.Models;

namespace eShiftApp.Views.Admin
{
    public partial class ManageProductControl : UserControl
    {
        private ProductController _productController = new ProductController();

        public ManageProductControl()
        {
            InitializeComponent();

            //txtProductId.Leave += TxtProductId_Leave; //auto aerch hook
            this.txtProductId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductId_KeyDown);

        }

        // Auto load product by ID when user leaves the productId field
        //private void TxtProductId_Leave(object sender, EventArgs e)
        //{
        //    if (int.TryParse(txtProductId.Text.Trim(), out int productId))
        //    {
        //        var product = _productController.GetProductById(productId);
        //        if (product != null)
        //        {
        //            txtProductName.Text = product.Name;
        //            txtProductDescription.Text = product.Description;
        //        }
        //        else
        //        {
        //            txtProductName.Clear();
        //            txtProductDescription.Clear();
        //        }
        //    }
        //    else
        //    {
        //        txtProductName.Clear();
        //        txtProductDescription.Clear();
        //    }
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text.Trim();
            string description = txtProductDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Name and Description are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var product = new Product
            {
                Name = name,
                Description = description
            };

            int result = _productController.AddProduct(product);

            if (result > 0)
            {
                MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to add product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductId.Text.Trim(), out int productId))
            {
                MessageBox.Show("Please enter a valid Product ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtProductName.Text.Trim();
            string description = txtProductDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Name and Description cannot be empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var product = new Product
            {
                ProductId = productId,
                Name = name,
                Description = description
            };

            int result = _productController.UpdateProduct(product);

            if (result > 0)
            {
                MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to update product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductId.Text.Trim(), out int productId))
            {
                MessageBox.Show("Please enter a valid Product ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            int result = _productController.DeleteProduct(productId);

            if (result > 0)
            {
                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtProductDescription.Clear();
        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadProductDetails()
        {
            if (int.TryParse(txtProductId.Text.Trim(), out int productId))
            {
                var product = _productController.GetProductById(productId);
                if (product != null)
                {
                    txtProductName.Text = product.Name;
                    txtProductDescription.Text = product.Description;
                }
                else
                {
                    MessageBox.Show("Product not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearProductFieldsExceptId();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Product ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearProductFieldsExceptId();
            }
        }

        private void ClearProductFieldsExceptId()
        {
            txtProductName.Clear();
            txtProductDescription.Clear();
        }

        private void txtProductId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadProductDetails();
                e.SuppressKeyPress = true;
            }
        }



    }
}
