namespace ProductInventoryForms
{
    partial class FormProductInventory
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxProductsInStore = new System.Windows.Forms.ListBox();
            this.listBoxProductsInInventory = new System.Windows.Forms.ListBox();
            this.labelProductsTotalPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemoveInventoryProduct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClearAllInventoryProducts = new System.Windows.Forms.Button();
            this.buttonProductsTotalprice = new System.Windows.Forms.Button();
            this.labelValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonAdd.Location = new System.Drawing.Point(423, 174);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(268, 35);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add product to inventory";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxProductsInStore
            // 
            this.listBoxProductsInStore.FormattingEnabled = true;
            this.listBoxProductsInStore.HorizontalScrollbar = true;
            this.listBoxProductsInStore.ItemHeight = 20;
            this.listBoxProductsInStore.Location = new System.Drawing.Point(34, 134);
            this.listBoxProductsInStore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxProductsInStore.Name = "listBoxProductsInStore";
            this.listBoxProductsInStore.Size = new System.Drawing.Size(361, 104);
            this.listBoxProductsInStore.TabIndex = 2;
            // 
            // listBoxProductsInInventory
            // 
            this.listBoxProductsInInventory.FormattingEnabled = true;
            this.listBoxProductsInInventory.ItemHeight = 20;
            this.listBoxProductsInInventory.Location = new System.Drawing.Point(714, 134);
            this.listBoxProductsInInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxProductsInInventory.Name = "listBoxProductsInInventory";
            this.listBoxProductsInInventory.Size = new System.Drawing.Size(388, 104);
            this.listBoxProductsInInventory.TabIndex = 3;
            // 
            // labelProductsTotalPrice
            // 
            this.labelProductsTotalPrice.AutoSize = true;
            this.labelProductsTotalPrice.Location = new System.Drawing.Point(1083, 318);
            this.labelProductsTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductsTotalPrice.Name = "labelProductsTotalPrice";
            this.labelProductsTotalPrice.Size = new System.Drawing.Size(0, 20);
            this.labelProductsTotalPrice.TabIndex = 4;
            this.labelProductsTotalPrice.Click += new System.EventHandler(this.labelProductsTotalPrice_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "All Products";
            // 
            // buttonRemoveInventoryProduct
            // 
            this.buttonRemoveInventoryProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveInventoryProduct.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonRemoveInventoryProduct.Location = new System.Drawing.Point(360, 309);
            this.buttonRemoveInventoryProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemoveInventoryProduct.Name = "buttonRemoveInventoryProduct";
            this.buttonRemoveInventoryProduct.Size = new System.Drawing.Size(386, 35);
            this.buttonRemoveInventoryProduct.TabIndex = 6;
            this.buttonRemoveInventoryProduct.Text = "Remove this product from inventory";
            this.buttonRemoveInventoryProduct.UseVisualStyleBackColor = true;
            this.buttonRemoveInventoryProduct.Click += new System.EventHandler(this.buttonRemoveInventoryProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(726, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inventory";
            // 
            // buttonClearAllInventoryProducts
            // 
            this.buttonClearAllInventoryProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearAllInventoryProducts.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonClearAllInventoryProducts.Location = new System.Drawing.Point(360, 369);
            this.buttonClearAllInventoryProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClearAllInventoryProducts.Name = "buttonClearAllInventoryProducts";
            this.buttonClearAllInventoryProducts.Size = new System.Drawing.Size(386, 35);
            this.buttonClearAllInventoryProducts.TabIndex = 8;
            this.buttonClearAllInventoryProducts.Text = "Remove all products from inventory";
            this.buttonClearAllInventoryProducts.UseVisualStyleBackColor = true;
            this.buttonClearAllInventoryProducts.Click += new System.EventHandler(this.buttonClearAllInventoryProducts_Click);
            // 
            // buttonProductsTotalprice
            // 
            this.buttonProductsTotalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProductsTotalprice.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonProductsTotalprice.Location = new System.Drawing.Point(794, 309);
            this.buttonProductsTotalprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonProductsTotalprice.Name = "buttonProductsTotalprice";
            this.buttonProductsTotalprice.Size = new System.Drawing.Size(268, 35);
            this.buttonProductsTotalprice.TabIndex = 13;
            this.buttonProductsTotalprice.Text = "Total price :";
            this.buttonProductsTotalprice.UseVisualStyleBackColor = true;
            this.buttonProductsTotalprice.Click += new System.EventHandler(this.buttonProductsTotalprice_Click);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(1117, 318);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(0, 20);
            this.labelValue.TabIndex = 14;
            // 
            // FormProductInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 666);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.buttonProductsTotalprice);
            this.Controls.Add(this.buttonClearAllInventoryProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRemoveInventoryProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelProductsTotalPrice);
            this.Controls.Add(this.listBoxProductsInInventory);
            this.Controls.Add(this.listBoxProductsInStore);
            this.Controls.Add(this.buttonAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormProductInventory";
            this.Text = "Product Inventory";
            this.Load += new System.EventHandler(this.FormProductInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxProductsInStore;
        private System.Windows.Forms.ListBox listBoxProductsInInventory;
        private System.Windows.Forms.Label labelProductsTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRemoveInventoryProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClearAllInventoryProducts;
        private System.Windows.Forms.Button buttonProductsTotalprice;
        private System.Windows.Forms.Label labelValue;
    }
}

