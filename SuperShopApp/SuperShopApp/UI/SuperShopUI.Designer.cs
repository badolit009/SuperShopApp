namespace SuperShopApp
{
    partial class SuperShopUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.viewAllButton = new System.Windows.Forms.Button();
            this.productListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.totalQuantityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Code";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(178, 19);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(220, 20);
            this.codeTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(274, 126);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(124, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(178, 61);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(220, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(178, 100);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(220, 20);
            this.quantityTextBox.TabIndex = 6;
            // 
            // viewAllButton
            // 
            this.viewAllButton.Location = new System.Drawing.Point(274, 157);
            this.viewAllButton.Name = "viewAllButton";
            this.viewAllButton.Size = new System.Drawing.Size(124, 23);
            this.viewAllButton.TabIndex = 7;
            this.viewAllButton.Text = "View All";
            this.viewAllButton.UseVisualStyleBackColor = true;
            this.viewAllButton.Click += new System.EventHandler(this.viewAllButton_Click);
            // 
            // productListView
            // 
            this.productListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.productListView.FullRowSelect = true;
            this.productListView.GridLines = true;
            this.productListView.Location = new System.Drawing.Point(43, 186);
            this.productListView.MultiSelect = false;
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(355, 97);
            this.productListView.TabIndex = 8;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Code";
            this.columnHeader1.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 149;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Quantity";
            // 
            // totalQuantityTextBox
            // 
            this.totalQuantityTextBox.Location = new System.Drawing.Point(178, 301);
            this.totalQuantityTextBox.Name = "totalQuantityTextBox";
            this.totalQuantityTextBox.Size = new System.Drawing.Size(220, 20);
            this.totalQuantityTextBox.TabIndex = 10;
            // 
            // SuperShopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 331);
            this.Controls.Add(this.totalQuantityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productListView);
            this.Controls.Add(this.viewAllButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SuperShopUI";
            this.Text = "SuperShopUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button viewAllButton;
        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalQuantityTextBox;
    }
}

