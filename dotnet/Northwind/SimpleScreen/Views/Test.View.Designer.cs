namespace Northwind.SimpleScreen.Views
{
    partial class TestView
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
            this.grid1 = new Northwind.Shared.Theme.Controls.Grid();
            this.gcProductID = new Northwind.Shared.Theme.Controls.GridColumn();
            this.txtProductID = new Northwind.Shared.Theme.Controls.TextBox();
            this.gcProductName = new Northwind.Shared.Theme.Controls.GridColumn();
            this.txtProductName = new Northwind.Shared.Theme.Controls.TextBox();
            this.gcCategoryID = new Northwind.Shared.Theme.Controls.GridColumn();
            this.txtCategoryID = new Northwind.Shared.Theme.Controls.TextBox();
            this.gcUnitPrice = new Northwind.Shared.Theme.Controls.GridColumn();
            this.txtUnitPrice = new Northwind.Shared.Theme.Controls.TextBox();
            this.gcUnitsInStock = new Northwind.Shared.Theme.Controls.GridColumn();
            this.txtUnitsInStock = new Northwind.Shared.Theme.Controls.TextBox();
            this.gcUnitsOnOrder = new Northwind.Shared.Theme.Controls.GridColumn();
            this.txtUnitsOnOrder = new Northwind.Shared.Theme.Controls.TextBox();
            this.grid1.SuspendLayout();
            this.gcProductID.SuspendLayout();
            this.gcProductName.SuspendLayout();
            this.gcCategoryID.SuspendLayout();
            this.gcUnitPrice.SuspendLayout();
            this.gcUnitsInStock.SuspendLayout();
            this.gcUnitsOnOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.Controls.Add(this.gcProductID);
            this.grid1.Controls.Add(this.gcProductName);
            this.grid1.Controls.Add(this.gcCategoryID);
            this.grid1.Controls.Add(this.gcUnitPrice);
            this.grid1.Controls.Add(this.gcUnitsInStock);
            this.grid1.Controls.Add(this.gcUnitsOnOrder);
            this.grid1.Location = new System.Drawing.Point(7, 19);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(750, 405);
            this.grid1.Text = "grid1";
            // 
            // gcProductID
            // 
            this.gcProductID.Controls.Add(this.txtProductID);
            this.gcProductID.Name = "gcProductID";
            this.gcProductID.Text = "ProductID";
            this.gcProductID.Width = 109;
            // 
            // txtProductID
            // 
            this.txtProductID.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.txtProductID.Location = new System.Drawing.Point(2, 1);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(103, 18);
            this.txtProductID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtProductID.Data = this._controller.products.ProductID;
            // 
            // gcProductName
            // 
            this.gcProductName.Controls.Add(this.txtProductName);
            this.gcProductName.Name = "gcProductName";
            this.gcProductName.Text = "ProductName";
            this.gcProductName.Width = 235;
            // 
            // txtProductName
            // 
            this.txtProductName.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.txtProductName.Location = new System.Drawing.Point(2, 1);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(229, 18);
            this.txtProductName.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtProductName.Data = this._controller.products.ProductName;
            // 
            // gcCategoryID
            // 
            this.gcCategoryID.Controls.Add(this.txtCategoryID);
            this.gcCategoryID.Name = "gcCategoryID";
            this.gcCategoryID.Text = "CategoryID";
            this.gcCategoryID.Width = 109;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.txtCategoryID.Location = new System.Drawing.Point(2, 1);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(103, 18);
            this.txtCategoryID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtCategoryID.Data = this._controller.products.CategoryID;
            // 
            // gcUnitPrice
            // 
            this.gcUnitPrice.Controls.Add(this.txtUnitPrice);
            this.gcUnitPrice.Name = "gcUnitPrice";
            this.gcUnitPrice.Text = "UnitPrice";
            this.gcUnitPrice.Width = 136;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.txtUnitPrice.Location = new System.Drawing.Point(2, 1);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(130, 18);
            this.txtUnitPrice.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUnitPrice.Data = this._controller.products.UnitPrice;
            // 
            // gcUnitsInStock
            // 
            this.gcUnitsInStock.Controls.Add(this.txtUnitsInStock);
            this.gcUnitsInStock.Name = "gcUnitsInStock";
            this.gcUnitsInStock.Text = "UnitsInStock";
            this.gcUnitsInStock.Width = 69;
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.txtUnitsInStock.Location = new System.Drawing.Point(2, 1);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(58, 18);
            this.txtUnitsInStock.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUnitsInStock.Data = this._controller.products.UnitsInStock;
            // 
            // gcUnitsOnOrder
            // 
            this.gcUnitsOnOrder.Controls.Add(this.txtUnitsOnOrder);
            this.gcUnitsOnOrder.Name = "gcUnitsOnOrder";
            this.gcUnitsOnOrder.Text = "UnitsOnOrder";
            this.gcUnitsOnOrder.Width = 72;
            // 
            // txtUnitsOnOrder
            // 
            this.txtUnitsOnOrder.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.txtUnitsOnOrder.Location = new System.Drawing.Point(2, 1);
            this.txtUnitsOnOrder.Name = "txtUnitsOnOrder";
            this.txtUnitsOnOrder.Size = new System.Drawing.Size(58, 18);
            this.txtUnitsOnOrder.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUnitsOnOrder.Data = this._controller.products.UnitsOnOrder;
            // 
            // TestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 431);
            this.Controls.Add(this.grid1);
            this.HorizontalExpressionFactor = 1D;
            this.HorizontalScale = 1D;
            this.Name = "TestView";
            this.Text = "Test";
            this.VerticalExpressionFactor = 1D;
            this.VerticalScale = 1D;
            this.grid1.ResumeLayout(false);
            this.gcProductID.ResumeLayout(false);
            this.gcProductName.ResumeLayout(false);
            this.gcCategoryID.ResumeLayout(false);
            this.gcUnitPrice.ResumeLayout(false);
            this.gcUnitsInStock.ResumeLayout(false);
            this.gcUnitsOnOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Shared.Theme.Controls.Grid grid1;
        private Shared.Theme.Controls.GridColumn gcProductID;
        private Shared.Theme.Controls.TextBox txtProductID;
        private Shared.Theme.Controls.GridColumn gcProductName;
        private Shared.Theme.Controls.TextBox txtProductName;
        private Shared.Theme.Controls.GridColumn gcCategoryID;
        private Shared.Theme.Controls.TextBox txtCategoryID;
        private Shared.Theme.Controls.GridColumn gcUnitPrice;
        private Shared.Theme.Controls.TextBox txtUnitPrice;
        private Shared.Theme.Controls.GridColumn gcUnitsInStock;
        private Shared.Theme.Controls.TextBox txtUnitsInStock;
        private Shared.Theme.Controls.GridColumn gcUnitsOnOrder;
        private Shared.Theme.Controls.TextBox txtUnitsOnOrder;
    }
}