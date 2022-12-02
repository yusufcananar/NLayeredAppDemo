namespace Northwind.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.lblAddUnitPrice = new System.Windows.Forms.Label();
            this.lblAddQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblAddUnitsInStock = new System.Windows.Forms.Label();
            this.lblAddCategoryId = new System.Windows.Forms.Label();
            this.tbxAddProductName = new System.Windows.Forms.TextBox();
            this.cbxAddCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxAddQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxAddUnitsInStock = new System.Windows.Forms.TextBox();
            this.tbxAddUnitPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxProductUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxUpdateUnitsInStock = new System.Windows.Forms.TextBox();
            this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.cbxUpdateCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.lblUpdateCategoryId = new System.Windows.Forms.Label();
            this.lblUpdateUnitsInStock = new System.Windows.Forms.Label();
            this.lblUpdateQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblUpdateUnitPrice = new System.Windows.Forms.Label();
            this.lblUpdateProductName = new System.Windows.Forms.Label();
            this.gbxProductDelete = new System.Windows.Forms.GroupBox();
            this.tbxDeleteProductName = new System.Windows.Forms.TextBox();
            this.lblDeleteProductName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gbxProductUpdate.SuspendLayout();
            this.gbxProductDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 177);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(776, 155);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(776, 74);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Search by Category";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(95, 33);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(197, 21);
            this.cbxCategory.TabIndex = 3;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(40, 36);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(12, 92);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(776, 79);
            this.gbxProductName.TabIndex = 0;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Search by Name";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(158, 35);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(134, 20);
            this.tbxProductName.TabIndex = 2;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(40, 38);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(112, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Search Product Name";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.tbxAddUnitPrice);
            this.gbxProductAdd.Controls.Add(this.tbxAddUnitsInStock);
            this.gbxProductAdd.Controls.Add(this.tbxAddQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.cbxAddCategoryId);
            this.gbxProductAdd.Controls.Add(this.tbxAddProductName);
            this.gbxProductAdd.Controls.Add(this.lblAddCategoryId);
            this.gbxProductAdd.Controls.Add(this.lblAddUnitsInStock);
            this.gbxProductAdd.Controls.Add(this.lblAddQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblAddUnitPrice);
            this.gbxProductAdd.Controls.Add(this.lblAddProductName);
            this.gbxProductAdd.Location = new System.Drawing.Point(12, 338);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(260, 197);
            this.gbxProductAdd.TabIndex = 2;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Add New Product";
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Location = new System.Drawing.Point(21, 28);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(75, 13);
            this.lblAddProductName.TabIndex = 0;
            this.lblAddProductName.Text = "Product Name";
            // 
            // lblAddUnitPrice
            // 
            this.lblAddUnitPrice.AutoSize = true;
            this.lblAddUnitPrice.Location = new System.Drawing.Point(21, 54);
            this.lblAddUnitPrice.Name = "lblAddUnitPrice";
            this.lblAddUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblAddUnitPrice.TabIndex = 1;
            this.lblAddUnitPrice.Text = "Unit Price";
            // 
            // lblAddQuantityPerUnit
            // 
            this.lblAddQuantityPerUnit.AutoSize = true;
            this.lblAddQuantityPerUnit.Location = new System.Drawing.Point(21, 80);
            this.lblAddQuantityPerUnit.Name = "lblAddQuantityPerUnit";
            this.lblAddQuantityPerUnit.Size = new System.Drawing.Size(81, 13);
            this.lblAddQuantityPerUnit.TabIndex = 2;
            this.lblAddQuantityPerUnit.Text = "QuantityPerUnit";
            // 
            // lblAddUnitsInStock
            // 
            this.lblAddUnitsInStock.AutoSize = true;
            this.lblAddUnitsInStock.Location = new System.Drawing.Point(21, 106);
            this.lblAddUnitsInStock.Name = "lblAddUnitsInStock";
            this.lblAddUnitsInStock.Size = new System.Drawing.Size(68, 13);
            this.lblAddUnitsInStock.TabIndex = 3;
            this.lblAddUnitsInStock.Text = "UnitsInStock";
            // 
            // lblAddCategoryId
            // 
            this.lblAddCategoryId.AutoSize = true;
            this.lblAddCategoryId.Location = new System.Drawing.Point(21, 132);
            this.lblAddCategoryId.Name = "lblAddCategoryId";
            this.lblAddCategoryId.Size = new System.Drawing.Size(49, 13);
            this.lblAddCategoryId.TabIndex = 4;
            this.lblAddCategoryId.Text = "Category";
            // 
            // tbxAddProductName
            // 
            this.tbxAddProductName.Location = new System.Drawing.Point(140, 25);
            this.tbxAddProductName.Name = "tbxAddProductName";
            this.tbxAddProductName.Size = new System.Drawing.Size(100, 20);
            this.tbxAddProductName.TabIndex = 5;
            // 
            // cbxAddCategoryId
            // 
            this.cbxAddCategoryId.FormattingEnabled = true;
            this.cbxAddCategoryId.Location = new System.Drawing.Point(140, 129);
            this.cbxAddCategoryId.Name = "cbxAddCategoryId";
            this.cbxAddCategoryId.Size = new System.Drawing.Size(100, 21);
            this.cbxAddCategoryId.TabIndex = 6;
            // 
            // tbxAddQuantityPerUnit
            // 
            this.tbxAddQuantityPerUnit.Location = new System.Drawing.Point(140, 77);
            this.tbxAddQuantityPerUnit.Name = "tbxAddQuantityPerUnit";
            this.tbxAddQuantityPerUnit.Size = new System.Drawing.Size(100, 20);
            this.tbxAddQuantityPerUnit.TabIndex = 7;
            // 
            // tbxAddUnitsInStock
            // 
            this.tbxAddUnitsInStock.Location = new System.Drawing.Point(140, 103);
            this.tbxAddUnitsInStock.Name = "tbxAddUnitsInStock";
            this.tbxAddUnitsInStock.Size = new System.Drawing.Size(100, 20);
            this.tbxAddUnitsInStock.TabIndex = 8;
            // 
            // tbxAddUnitPrice
            // 
            this.tbxAddUnitPrice.Location = new System.Drawing.Point(140, 51);
            this.tbxAddUnitPrice.Name = "tbxAddUnitPrice";
            this.tbxAddUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxAddUnitPrice.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(77, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxProductUpdate
            // 
            this.gbxProductUpdate.Controls.Add(this.btnUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxUpdateUnitPrice);
            this.gbxProductUpdate.Controls.Add(this.tbxUpdateUnitsInStock);
            this.gbxProductUpdate.Controls.Add(this.tbxUpdateQuantityPerUnit);
            this.gbxProductUpdate.Controls.Add(this.cbxUpdateCategoryId);
            this.gbxProductUpdate.Controls.Add(this.tbxUpdateProductName);
            this.gbxProductUpdate.Controls.Add(this.lblUpdateCategoryId);
            this.gbxProductUpdate.Controls.Add(this.lblUpdateUnitsInStock);
            this.gbxProductUpdate.Controls.Add(this.lblUpdateQuantityPerUnit);
            this.gbxProductUpdate.Controls.Add(this.lblUpdateUnitPrice);
            this.gbxProductUpdate.Controls.Add(this.lblUpdateProductName);
            this.gbxProductUpdate.Location = new System.Drawing.Point(278, 338);
            this.gbxProductUpdate.Name = "gbxProductUpdate";
            this.gbxProductUpdate.Size = new System.Drawing.Size(252, 197);
            this.gbxProductUpdate.TabIndex = 3;
            this.gbxProductUpdate.TabStop = false;
            this.gbxProductUpdate.Text = "Update Product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(77, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(140, 51);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateUnitPrice.TabIndex = 9;
            // 
            // tbxUpdateUnitsInStock
            // 
            this.tbxUpdateUnitsInStock.Location = new System.Drawing.Point(140, 103);
            this.tbxUpdateUnitsInStock.Name = "tbxUpdateUnitsInStock";
            this.tbxUpdateUnitsInStock.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateUnitsInStock.TabIndex = 8;
            // 
            // tbxUpdateQuantityPerUnit
            // 
            this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(140, 77);
            this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateQuantityPerUnit.TabIndex = 7;
            // 
            // cbxUpdateCategoryId
            // 
            this.cbxUpdateCategoryId.FormattingEnabled = true;
            this.cbxUpdateCategoryId.Location = new System.Drawing.Point(140, 129);
            this.cbxUpdateCategoryId.Name = "cbxUpdateCategoryId";
            this.cbxUpdateCategoryId.Size = new System.Drawing.Size(100, 21);
            this.cbxUpdateCategoryId.TabIndex = 6;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(140, 25);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateProductName.TabIndex = 5;
            // 
            // lblUpdateCategoryId
            // 
            this.lblUpdateCategoryId.AutoSize = true;
            this.lblUpdateCategoryId.Location = new System.Drawing.Point(21, 132);
            this.lblUpdateCategoryId.Name = "lblUpdateCategoryId";
            this.lblUpdateCategoryId.Size = new System.Drawing.Size(49, 13);
            this.lblUpdateCategoryId.TabIndex = 4;
            this.lblUpdateCategoryId.Text = "Category";
            // 
            // lblUpdateUnitsInStock
            // 
            this.lblUpdateUnitsInStock.AutoSize = true;
            this.lblUpdateUnitsInStock.Location = new System.Drawing.Point(21, 106);
            this.lblUpdateUnitsInStock.Name = "lblUpdateUnitsInStock";
            this.lblUpdateUnitsInStock.Size = new System.Drawing.Size(68, 13);
            this.lblUpdateUnitsInStock.TabIndex = 3;
            this.lblUpdateUnitsInStock.Text = "UnitsInStock";
            // 
            // lblUpdateQuantityPerUnit
            // 
            this.lblUpdateQuantityPerUnit.AutoSize = true;
            this.lblUpdateQuantityPerUnit.Location = new System.Drawing.Point(21, 80);
            this.lblUpdateQuantityPerUnit.Name = "lblUpdateQuantityPerUnit";
            this.lblUpdateQuantityPerUnit.Size = new System.Drawing.Size(81, 13);
            this.lblUpdateQuantityPerUnit.TabIndex = 2;
            this.lblUpdateQuantityPerUnit.Text = "QuantityPerUnit";
            // 
            // lblUpdateUnitPrice
            // 
            this.lblUpdateUnitPrice.AutoSize = true;
            this.lblUpdateUnitPrice.Location = new System.Drawing.Point(21, 54);
            this.lblUpdateUnitPrice.Name = "lblUpdateUnitPrice";
            this.lblUpdateUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUpdateUnitPrice.TabIndex = 1;
            this.lblUpdateUnitPrice.Text = "Unit Price";
            // 
            // lblUpdateProductName
            // 
            this.lblUpdateProductName.AutoSize = true;
            this.lblUpdateProductName.Location = new System.Drawing.Point(21, 28);
            this.lblUpdateProductName.Name = "lblUpdateProductName";
            this.lblUpdateProductName.Size = new System.Drawing.Size(75, 13);
            this.lblUpdateProductName.TabIndex = 0;
            this.lblUpdateProductName.Text = "Product Name";
            // 
            // gbxProductDelete
            // 
            this.gbxProductDelete.Controls.Add(this.btnDelete);
            this.gbxProductDelete.Controls.Add(this.tbxDeleteProductName);
            this.gbxProductDelete.Controls.Add(this.lblDeleteProductName);
            this.gbxProductDelete.Location = new System.Drawing.Point(536, 338);
            this.gbxProductDelete.Name = "gbxProductDelete";
            this.gbxProductDelete.Size = new System.Drawing.Size(252, 197);
            this.gbxProductDelete.TabIndex = 4;
            this.gbxProductDelete.TabStop = false;
            this.gbxProductDelete.Text = "Delete Product";
            // 
            // tbxDeleteProductName
            // 
            this.tbxDeleteProductName.Location = new System.Drawing.Point(140, 25);
            this.tbxDeleteProductName.Name = "tbxDeleteProductName";
            this.tbxDeleteProductName.Size = new System.Drawing.Size(100, 20);
            this.tbxDeleteProductName.TabIndex = 5;
            // 
            // lblDeleteProductName
            // 
            this.lblDeleteProductName.AutoSize = true;
            this.lblDeleteProductName.Location = new System.Drawing.Point(21, 28);
            this.lblDeleteProductName.Name = "lblDeleteProductName";
            this.lblDeleteProductName.Size = new System.Drawing.Size(75, 13);
            this.lblDeleteProductName.TabIndex = 0;
            this.lblDeleteProductName.Text = "Product Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(77, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.gbxProductDelete);
            this.Controls.Add(this.gbxProductUpdate);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxProductUpdate.ResumeLayout(false);
            this.gbxProductUpdate.PerformLayout();
            this.gbxProductDelete.ResumeLayout(false);
            this.gbxProductDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Label lblAddUnitsInStock;
        private System.Windows.Forms.Label lblAddQuantityPerUnit;
        private System.Windows.Forms.Label lblAddUnitPrice;
        private System.Windows.Forms.Label lblAddProductName;
        private System.Windows.Forms.Label lblAddCategoryId;
        private System.Windows.Forms.TextBox tbxAddUnitPrice;
        private System.Windows.Forms.TextBox tbxAddUnitsInStock;
        private System.Windows.Forms.TextBox tbxAddQuantityPerUnit;
        private System.Windows.Forms.ComboBox cbxAddCategoryId;
        private System.Windows.Forms.TextBox tbxAddProductName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxProductUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.TextBox tbxUpdateUnitsInStock;
        private System.Windows.Forms.TextBox tbxUpdateQuantityPerUnit;
        private System.Windows.Forms.ComboBox cbxUpdateCategoryId;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label lblUpdateCategoryId;
        private System.Windows.Forms.Label lblUpdateUnitsInStock;
        private System.Windows.Forms.Label lblUpdateQuantityPerUnit;
        private System.Windows.Forms.Label lblUpdateUnitPrice;
        private System.Windows.Forms.Label lblUpdateProductName;
        private System.Windows.Forms.GroupBox gbxProductDelete;
        private System.Windows.Forms.TextBox tbxDeleteProductName;
        private System.Windows.Forms.Label lblDeleteProductName;
        private System.Windows.Forms.Button btnDelete;
    }
}

