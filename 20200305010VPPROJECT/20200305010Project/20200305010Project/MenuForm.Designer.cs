namespace _20200305010Project
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            btnControl = new Button();
            btnAdmin = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnControl
            // 
            btnControl.BackColor = Color.Gray;
            btnControl.FlatStyle = FlatStyle.Flat;
            btnControl.ForeColor = Color.White;
            btnControl.Location = new Point(243, 185);
            btnControl.Name = "btnControl";
            btnControl.Size = new Size(75, 23);
            btnControl.TabIndex = 0;
            btnControl.Text = "GO";
            btnControl.UseVisualStyleBackColor = false;
            btnControl.Click += btnControl_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Gray;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(243, 288);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(75, 23);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "GO";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(192, 133);
            label1.Name = "label1";
            label1.Size = new Size(177, 37);
            label1.TabIndex = 2;
            label1.Text = "Control Panel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGray;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(192, 232);
            label2.Name = "label2";
            label2.Size = new Size(166, 37);
            label2.TabIndex = 3;
            label2.Text = "Admin Panel";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(216, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(580, 357);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdmin);
            Controls.Add(btnControl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnControl;
        private Button btnAdmin;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}