namespace _20200305010Project
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            lblId = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textid = new TextBox();
            textName = new TextBox();
            textBrand = new TextBox();
            textQuantity = new TextBox();
            listViewProducts = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 1;
            label1.Text = "Admin Panel";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.car_check__1_;
            pictureBox1.Location = new Point(54, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(21, 285);
            button1.Name = "button1";
            button1.Size = new Size(144, 40);
            button1.TabIndex = 3;
            button1.Text = "Add Product";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnAddProduct_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Black;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(21, 314);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(144, 40);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit Product";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEditProduct_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Black;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(21, 343);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 40);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Product";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDeleteProduct_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Black;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(21, 380);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(144, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(21, 141);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 7;
            lblId.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 180);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 8;
            label3.Text = "NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 218);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 9;
            label4.Text = "BRAND";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 247);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 10;
            label5.Text = "QUANTITY";
            // 
            // textid
            // 
            textid.Location = new Point(96, 138);
            textid.Name = "textid";
            textid.Size = new Size(100, 23);
            textid.TabIndex = 11;
            // 
            // textName
            // 
            textName.Location = new Point(96, 177);
            textName.Name = "textName";
            textName.Size = new Size(100, 23);
            textName.TabIndex = 12;
            // 
            // textBrand
            // 
            textBrand.Location = new Point(96, 215);
            textBrand.Name = "textBrand";
            textBrand.Size = new Size(100, 23);
            textBrand.TabIndex = 13;
            // 
            // textQuantity
            // 
            textQuantity.Location = new Point(96, 244);
            textQuantity.Name = "textQuantity";
            textQuantity.Size = new Size(100, 23);
            textQuantity.TabIndex = 14;
            // 
            // listViewProducts
            // 
            listViewProducts.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewProducts.Location = new Point(304, 29);
            listViewProducts.Name = "listViewProducts";
            listViewProducts.Size = new Size(323, 380);
            listViewProducts.TabIndex = 15;
            listViewProducts.UseCompatibleStateImageBehavior = false;
            listViewProducts.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "NAME";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "BRAND";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "QUANTITY";
            columnHeader4.Width = 80;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(668, 427);
            Controls.Add(listViewProducts);
            Controls.Add(textQuantity);
            Controls.Add(textBrand);
            Controls.Add(textName);
            Controls.Add(textid);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblId);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnBack;
        private Label lblId;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textid;
        private TextBox textName;
        private TextBox textBrand;
        private TextBox textQuantity;
        private ListView listViewProducts;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}